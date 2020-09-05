using AmazingInsta.Common.Application.CQRS.Events;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Events
{
    public abstract class PostEvent : Event
    {
        public Post Post { get; set; }

        public PostEvent()
            : base()
        {
        }
    }
}
