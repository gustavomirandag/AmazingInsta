using AmazingInsta.Microservices.PostMicroservice.PostWorker.Properties;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.PostWorker
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddServiceBus(sbOptions =>
                {
                    sbOptions.ConnectionString = Resources.ServiceBusConnectionString;
                    sbOptions.MessageHandlerOptions.AutoComplete = true;
                    sbOptions.MessageHandlerOptions.MaxConcurrentCalls = 16;
                });
            });
            var host = builder.Build();
            using (host)
            {
                await host.RunAsync();
            }
        }
    }
}
