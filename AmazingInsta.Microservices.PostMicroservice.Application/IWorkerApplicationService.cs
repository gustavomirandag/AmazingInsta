using AmazingInsta.Microservices.PostMicroservice.Application.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.Microservices.PostMicroservice.Application
{
    public interface IWorkerApplicationService
    {
        Task<bool> ProcessPostAsync(ProcessPostCommand command);
    }
}
