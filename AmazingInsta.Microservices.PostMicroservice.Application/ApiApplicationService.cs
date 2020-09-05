using AmazingInsta.Common.Application.CQRS.Messaging;
using AmazingInsta.Common.Domain.Services;
using AmazingInsta.Common.Infra.Helper.Serializers;
using AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using System;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Application
{
    public class ApiApplicationService : IApiApplicationService
    {
        private IPostService postService;
        private IMediatorHandler bus;

        public ApiApplicationService(IPostService postService, IMediatorHandler bus)
        {
            this.postService = postService;
            this.bus = bus;
        }

        public async Task CreatePostAsync(Guid profileId, string message, string photoUrl)
        {
            var post = postService.CreatePost(profileId, message, photoUrl);
            var command = new ProcessPostCommand(post);
            await bus.EnqueueAsync(command, command.QueueName);
        }
    }
}
