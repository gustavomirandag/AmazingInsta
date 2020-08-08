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
            optionsBuilder.UseSqlServer("Server=tcp:amazinginsta-gustavo-db-server.database.windows.net,1433;Initial Catalog=amazinginsta-gustavo-db;Persist Security Info=False;User ID=gustavo;Password=@dsInf123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
