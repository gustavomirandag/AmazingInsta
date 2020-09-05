using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands
{
    //User Case: Process Order
    public class ProcessPostCommand : PostCommand
    {
        public const string CommandQueueName = "process-post-command-queue";
        public override string QueueName => CommandQueueName;

        public ProcessPostCommand(Post post)
            :base(post)
        {
        }

        public ProcessPostCommand()
            :base()
        {
        }
    }
}
