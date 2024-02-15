using _01_PersonalizationApi;
using _01_PersonalizationApi.FluentValidation;
using _01_PersonalizationApi.GraphQL;
using Common;
using FluentValidation;
using HotChocolate.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<DeviceObjectType>()
    .AddType<SwitchPayloadObjectType>()
    .AddType<BlindPayloadObjectType>()
    .AddMutationType<Mutation>()
    .AddMutationConventions(false)
    .AddFairyBread()
    .AddInstrumentation(o =>
    {
        o.IncludeDocument = true;
        o.RequestDetails = RequestDetails.All;
        o.Scopes = ActivityScopes.All;
        o.RenameRootActivity = true;
    });

builder.AddTelemetry();
builder.Services.AddSingleton<DeviceRepository>();

builder.Services.AddValidatorsFromAssemblyContaining<CreateGroupInputValidator>();


builder.Services.AddHttpClient<BrokerApiClient>(client => { client.BaseAddress = new Uri("https://localhost:5051"); });
var app = builder.Build();

app.MapGraphQL();

app.Run();