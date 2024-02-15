using _03_PQ;
using Common;
using HotChocolate.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();

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
    .UsePersistedQueryPipeline()
    .AddReadOnlyFileSystemQueryStorage("./persisted_queries")
    .ModifyRequestOptions(o => o.OnlyAllowPersistedQueries = false);

var app = builder.Build();
app.MapGraphQL();
app.Run();