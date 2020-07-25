using AmazingInsta.Microservices.ProfileMicroservice.Domain.AggregatesModel.ProfileAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.ProfileMicroservice.Infra.DataAccess.Contexts
{
    public class ProfileContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("DB CONNECTION STRING");
        }
    }
}
