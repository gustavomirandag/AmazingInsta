using AmazingInsta.Common.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.App.Domain
{
    public interface IPostRepository : IRepository<Guid,Post>
    {
    }
}
