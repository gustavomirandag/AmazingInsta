using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmazingInsta.App.Domain
{
    public interface IPostService
    {
        Task AddPostAsync(Post post);

        Task<IEnumerable<Post>> GetAllPostsAsync();
    }
}
