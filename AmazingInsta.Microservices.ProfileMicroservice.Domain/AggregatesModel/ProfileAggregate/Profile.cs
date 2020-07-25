using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.ProfileMicroservice.Domain.AggregatesModel.ProfileAggregate
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; } //IAM Account
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
    }
}
