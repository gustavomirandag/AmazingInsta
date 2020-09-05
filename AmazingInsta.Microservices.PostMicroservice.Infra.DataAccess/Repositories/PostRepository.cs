using AmazingInsta.Common.Infra.DataAccess;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Infra.DataAccess.Repositories
{
    public class PostRepository : EntityFrameworkRepositoryBase<Guid,Post>, IPostRepository
    {
        public PostRepository(DbContext context)
            : base(context)
        {

        }
    }
}
