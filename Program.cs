using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = new HostBuilder()
        //.ConfigureAppConfiguration(builder =>
        //{
        //    string cs = Environment.GetEnvironmentVariable("ConnectionString");
        //    builder.AddAzureAppConfiguration(cs);
        //})
        .ConfigureFunctionsWebApplication()
        .ConfigureServices(services =>
        {
            services.AddApplicationInsightsTelemetryWorkerService();
            services.ConfigureFunctionsApplicationInsights();
        })
        .Build();

        host.Run();
    }
}