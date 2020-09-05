using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate
{
    public interface IPostService
    {
        Post CreatePost(Guid profileId, string message, string photoUrl);
        Task<bool> ProcessPostAsync(Post post);
    }
}
