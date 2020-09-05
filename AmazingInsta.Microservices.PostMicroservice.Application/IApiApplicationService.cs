using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Application
{
    public interface IApiApplicationService
    {
        Task CreatePostAsync(Guid profileId, string message, string photoUrl);
    }
}
