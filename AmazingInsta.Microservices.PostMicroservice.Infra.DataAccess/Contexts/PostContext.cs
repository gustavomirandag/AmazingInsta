using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingInsta.Microservices.PostMicroservice.Infra.DataAccess.Contexts
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("DB CONNECTION STRING");
        }
    }
}
