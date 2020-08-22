using AmazingInsta.Microservices.IamMicroservice.Shared.Configuration.Identity;
using AmazingInsta.Microservices.IamMicroservice.STS.Identity.Configuration.Interfaces;

namespace AmazingInsta.Microservices.IamMicroservice.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}





