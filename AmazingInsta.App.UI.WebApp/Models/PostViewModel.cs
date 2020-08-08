using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazingInsta.App.UI.WebApp.Models
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public DateTime PublishDateTime { get; set; }
        public string PhotoUrl { get; set; }
        public string Message { get; set; }
    }
}
