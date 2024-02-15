using _03_APQ;
using Common;
using DotNet.Testcontainers.Builders;
using HotChocolate.Diagnostics;
using HotChocolate.Execution;
using HotChocolate.Execution.Instrumentation;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

// var mockOAuth2Server = new ContainerBuilder()
//     .WithImage("jaegertracing/all-in-one:1.22")
//     .WithHostname("jaeger")
//     .WithEnvironment(new Dictionary<string, string>()
//     {
//         { "COLLECTOR_OTLP_ENABLED", true.ToString() }
//         // { "JSON_CONFIG_PATH", "/app/mockoauth2server.config.json" },
//     })
//     .WithHostname("localhost")
//     .WithPortBinding(5775, 5775)
//     .WithPortBinding(6831, 6831)
//     .WithPortBinding(6832, 6832)
//     .WithPortBinding(5778, 5778)
//     .WithPortBinding(4317, 4317)
//     .WithPortBinding(16686, 16686)
//     .WithPortBinding(14268, 14268)
//     .WithPortBinding(14250, 14250)
//     .WithPortBinding(9411, 9411)
//     .Build();

// await mockOAuth2Server.StartAsync().ConfigureAwait(false);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.AddTelemetry();
builder.Services
    .AddGraphQLServer()
    .AddDiagnosticEventListener<MyExecutionEventListener>()
    .AddInstrumentation(o =>
    {
        o.IncludeDocument = true;
        o.RequestDetails = RequestDetails.All;
        o.Scopes = ActivityScopes.All;
        o.RenameRootActivity = true;
    })
    .AddQueryType<Query>()
    .UseAutomaticPersistedQueryPipeline()
    .AddInMemoryQueryStorage();

var app = builder.Build();
app.MapGraphQL();
app.Run();

public class MyExecutionEventListener : ExecutionDiagnosticEventListener
{
    private readonly ILogger<MyExecutionEventListener> _logger;

    public MyExecutionEventListener(ILogger<MyExecutionEventListener> logger)
        => _logger = logger;

    public override void RequestError(IRequestContext context,
        Exception exception)
    {
        _logger.LogError(exception, "A request error occurred!");
    }
}