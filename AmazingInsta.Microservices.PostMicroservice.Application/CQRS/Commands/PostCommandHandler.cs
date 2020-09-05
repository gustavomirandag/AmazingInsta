using AmazingInsta.Common.Domain.Services;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands
{
    public class PostCommandHandler : IPostCommandHandler
    {
        private IPostService postService;

        public PostCommandHandler(IPostService postService)
        {
            this.postService = postService;
        }

        public async Task<bool> HandleAsync(ProcessPostCommand command)
        {
            return await postService.ProcessPostAsync(command.Post);
        }
    }
}
