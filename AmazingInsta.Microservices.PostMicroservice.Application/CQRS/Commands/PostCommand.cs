using AmazingInsta.Common.Application.CQRS.Commands;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands
{
    public abstract class PostCommand : Command
    {
        public Post Post { get; set; }

        protected PostCommand(Post post) : base()
        {
            Post = post;
        }

        protected PostCommand() : base()
        {
        }
    }
}
