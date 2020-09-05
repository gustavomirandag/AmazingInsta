using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands
{
    public interface IPostCommandHandler
    {
        Task<bool> HandleAsync(ProcessPostCommand command);
    }
}
