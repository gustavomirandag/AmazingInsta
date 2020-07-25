using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate
{
    public class Post
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public DateTime PublishDateTime { get; set; }
        public string PhotoUrl { get; set; }
        public string Message { get; set; }

    }
}
