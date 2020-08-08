using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate
{
    public class PostAddedEvent
    {
        public Post Post { get; set; }
    }
}
