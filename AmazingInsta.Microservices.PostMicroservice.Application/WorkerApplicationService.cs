using AmazingInsta.Common.Application.CQRS.Messaging;
using AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands;
using AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Application
{
    public class WorkerApplicationService : IWorkerApplicationService
    {
        private IPostCommandHandler postCommandHandler;
        private IMediatorHandler bus;

        public WorkerApplicationService(IPostCommandHandler postCommandHandler, IMediatorHandler bus)
        {
            this.postCommandHandler = postCommandHandler;
            this.bus = bus;
        }

        public async Task<bool> ProcessPostAsync(ProcessPostCommand command)
        {
            var isSuccess = await postCommandHandler.HandleAsync(command);

            //Create The Event
            var postProcessedEvent = new PostProcessedEvent(command.Post);
            postProcessedEvent.Success = isSuccess;
            await bus.EnqueueAsync(postProcessedEvent, postProcessedEvent.QueueName);

            return isSuccess;
        }
    }
}
