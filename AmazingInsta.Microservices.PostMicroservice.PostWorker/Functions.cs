using AmazingInsta.Common.Domain.Services;
using AmazingInsta.Common.Infra.Helper.Serializers;
using AmazingInsta.Common.Infra.Messaging.Services;
using AmazingInsta.Microservices.PostMicroservice.Application;
using AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using AmazingInsta.Microservices.PostMicroservice.Infra.DataAccess.Contexts;
using AmazingInsta.Microservices.PostMicroservice.Infra.DataAccess.Repositories;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.PostWorker
{
    public class Functions
    {
        private static IWorkerApplicationService workerApplicationService = new WorkerApplicationService(new PostCommandHandler(new PostService(new PostRepository(new PostContext()))), new AzureServiceBusQueue());
        private static ISerializerService serializerService = new SerializerService();

        public static async Task ProcessOrderCommandFunction([ServiceBusTrigger(ProcessPostCommand.CommandQueueName)] string message, ILogger logger)
        {
            logger.LogInformation(message);
            var command = serializerService.Deserialize<ProcessPostCommand>(message);
            await workerApplicationService.ProcessPostAsync(command);
        }
    }
}
