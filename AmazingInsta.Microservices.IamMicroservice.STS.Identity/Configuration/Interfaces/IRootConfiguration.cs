using AmazingInsta.Microservices.IamMicroservice.Shared.Configuration.Identity;

namespace AmazingInsta.Microservices.IamMicroservice.STS.Identity.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }

        RegisterConfiguration RegisterConfiguration { get; }
    }
}





