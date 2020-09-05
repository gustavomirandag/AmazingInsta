using AmazingInsta.Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate
{
    public class Post : EntityBase<Guid>
    {
        public Guid ProfileId { get; set; }
        public DateTime PublishDateTime { get; set; }
        public string PhotoUrl { get; set; }
        public string Message { get; set; }

    }
}
