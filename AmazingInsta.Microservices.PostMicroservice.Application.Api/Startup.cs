using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazingInsta.Common.Application.CQRS.Messaging;
using AmazingInsta.Common.Domain.Services;
using AmazingInsta.Common.Infra.Helper.Serializers;
using AmazingInsta.Common.Infra.Messaging.Services;
using AmazingInsta.Microservices.PostMicroservice.Domain.AggregatesModel.PostAggregate;
using AmazingInsta.Microservices.PostMicroservice.Infra.DataAccess.Contexts;
using AmazingInsta.Microservices.PostMicroservice.Infra.DataAccess.Repositories;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AmazingInsta.Microservices.PostMicroservice.Application.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<PostContext>();
            services.AddScoped<DbContext, PostContext>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ISerializerService, SerializerService>();
            services.AddScoped<IApiApplicationService, ApiApplicationService>();
            services.AddScoped<IMediatorHandler, AzureServiceBusQueue>();

            services.AddAuthorization();
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "https://amazinginsta-gustavo-iammicroservice-identity.azurewebsites.net";
                    options.RequireHttpsMetadata = false;
                    options.ApiName = "PostMicroservice_ApiResource";
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
