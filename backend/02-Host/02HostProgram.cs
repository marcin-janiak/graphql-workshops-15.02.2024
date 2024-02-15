using _02_Database;
using _02_Host.GraphQL;
using _02_Host.GraphQL.Devices;
using _02_Host.GraphQL.Groups;
using _02_Host.Validators;
using Common;
using DotNet.Testcontainers.Builders;
using FluentValidation;
using HotChocolate.AspNetCore;
using HotChocolate.Diagnostics;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using Testcontainers.PostgreSql;

var builder = WebApplication.CreateBuilder(args);

var postgreSqlContainer = new PostgreSqlBuilder().WithDatabase("db").WithUsername("admin").WithPassword("admin")
    .WithPortBinding(5432, 5432).Build();

await postgreSqlContainer
    .StartAsync().ConfigureAwait(false);
builder.WebHost.UseSetting("ConnectionStrings:WorkshopsDb", postgreSqlContainer.GetConnectionString());

var mockOAuth2Server = new ContainerBuilder()
    .WithResourceMapping(new FileInfo("Containers/mockoauth2server.config.json"), "/app/")
    .WithImage("ghcr.io/navikt/mock-oauth2-server:2.1.1")
    .WithEnvironment(new Dictionary<string, string>()
    {
        // { "JSON_CONFIG_PATH", "/app/mockoauth2server.config.json" },
    })
    .WithHostname("localhost")
    .WithPortBinding(8080, 8080).Build();

await mockOAuth2Server.StartAsync().ConfigureAwait(false);

builder.Services.AddPooledDbContextFactory<WorkshopsDbContext>(options => options
    .UseNpgsql(builder.Configuration.GetConnectionString("WorkshopsDb"),
        npgsqlOptions =>
        {
            npgsqlOptions.MigrationsHistoryTable("__EFMigrationsHistory", "public");
            npgsqlOptions.MigrationsAssembly(typeof(WorkshopsDbContext).Assembly.FullName);
        }));


builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters =
            new TokenValidationParameters
            {
                ValidIssuer = "http://localhost:8080/default",
                ValidAudience = "somescope",
                ValidateIssuerSigningKey = false,
                ValidateLifetime = false,
                SignatureValidator = ((token, parameters) => new JsonWebToken(token))
            };
    });

builder.Services.AddValidatorsFromAssemblyContaining<CreateGroupInputValidator>();
builder.AddTelemetry();

builder.Services
    .AddGraphQLServer()
    .AddInstrumentation(o =>
    {
        o.IncludeDocument = true;
        o.RequestDetails = RequestDetails.All;
        o.Scopes = ActivityScopes.All;
        o.RenameRootActivity = true;
    })
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType<GroupsQueryExtensions>()
    .AddType<GroupsMutationExtensions>()
    .AddType<SwitchPayloadObjectType>()
    .AddType<BlindPayloadObjectType>()
    .AddType<ThermometerPayloadObjectType>()
    .AddType<UserDeviceObjectType>()
    .AddType<DeviceObjectType>()
    .AddType<GroupObjectType>()
    .RegisterDbContext
        <WorkshopsDbContext>(DbContextKind.Pooled)
    .AddMutationConventions()
    .AddProjections()
    .AddSorting()
    .AddFiltering()
    .AddQueryableOffsetPagingProvider()
    .AddAuthorization()
    .ModifyOptions(o =>
    {
        o.EnableDefer = true;
        o.UseXmlDocumentation = true;
    })
    // .AllowIntrospection(false)
    .ModifyRequestOptions(o =>
    {
        o.Complexity.Enable = true;
        o.Complexity.MaximumAllowed = 9999; //50;
        o.ExecutionTimeout = TimeSpan.FromSeconds(10);
    })
    // .AddMaxExecutionDepthRule(12) //schema - 11
    // .SetMaxAllowedValidationErrors(10)
    .AddFairyBread();

var app = builder.Build();

MigrateDatabase(app);

app.UseAuthentication();
app.MapGraphQL()
    .WithOptions(new GraphQLServerOptions()
    {
        // Tool = { Enable = false, DisableTelemetry = true }
    });

await app.RunWithGraphQLCommandsAsync(args);

void MigrateDatabase(WebApplication webApplication)
{
    using var scope = webApplication.Services.CreateScope();
    var dbContextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<WorkshopsDbContext>>();
    var dbContext = dbContextFactory.CreateDbContext();

    dbContext.Database.EnsureDeleted();
    dbContext.Database.EnsureCreated();

    if (dbContext.Database.GetPendingMigrations().Any()) ;
    {
        try
        {
            dbContext.Database.Migrate();
        }
        catch (Exception ex)
        {
        }
    }
}