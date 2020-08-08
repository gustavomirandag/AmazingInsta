using IdentityServer4.Models;
using System.Collections.Generic;
using Client = AmazingInsta.Microservices.IamMicroservice.Admin.Configuration.IdentityServer.Client;

namespace AmazingInsta.Microservices.IamMicroservice.Admin.Configuration
{
    public class IdentityServerDataConfiguration
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<IdentityResource> IdentityResources { get; set; } = new List<IdentityResource>();
        public List<ApiResource> ApiResources { get; set; } = new List<ApiResource>();
    }
}






