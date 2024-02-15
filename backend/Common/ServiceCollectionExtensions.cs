using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace Common;

public static class ServiceCollectionExtensions
{
    public static WebApplicationBuilder AddTelemetry(this WebApplicationBuilder builder)
    {
        
        builder.Logging.AddOpenTelemetry(
            b =>
            {
                b.IncludeFormattedMessage = true;
                b.IncludeScopes = true;
                b.ParseStateValues = true;
                b.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("Demo"));
            });


        builder.Services
            .AddOpenTelemetry()
            .WithTracing(
                b =>
                {
                    b.AddHttpClientInstrumentation();
                    b.AddAspNetCoreInstrumentation();
                    b.AddHotChocolateInstrumentation();
                    b.AddOtlpExporter(o => { o.Endpoint = new Uri("http://127.0.0.1:4317"); });
                });

        return builder;
    }
}