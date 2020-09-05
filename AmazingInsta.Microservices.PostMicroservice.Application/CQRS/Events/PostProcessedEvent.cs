using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Events
{
    public class PostProcessedEvent : PostEvent
    {
        public const string EventQueueName = "post-processed-event-queue";
        public override string QueueName => EventQueueName;
        public bool Success { get; set; }

        public PostProcessedEvent(Post post)
            : base()
        {
            Post = post;
        }

        public PostProcessedEvent()
            : base()
        {
        }
    }
}
