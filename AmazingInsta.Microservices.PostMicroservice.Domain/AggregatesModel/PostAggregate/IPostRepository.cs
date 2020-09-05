using AmazingInsta.Common.Domain.Repositories;
using AmazingInsta.Common.Infra.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate
{
    public interface IPostRepository : IRepository<Guid,Post>
    {
    }
}
