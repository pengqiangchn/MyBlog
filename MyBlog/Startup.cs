﻿using Application.Services;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Modules.BlogAgg;
using Domain.Services;
using Domain.Services.Interfaces;
using Infrastructure.Crosscutting.Adapter;
using Infrastructure.Crosscutting.Localization;
using Infrastructure.Crosscutting.NetFramework.Adapter;
using Infrastructure.Crosscutting.NetFramework.Localization;
using Infrastructure.Crosscutting.NetFramework.Validator;
using Infrastructure.Crosscutting.Validator;
using Infrastructure.Data.Repositories;
using Infrastructure.Data.UnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBlog.Context;
using MyBlog.Profiles;

namespace MyBlog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure EntityFramework to use an InMemory database.
            //services.AddDbContext<MyBlogContext>(options =>
            //        options.UseMySql(Configuration.GetConnectionString("MyBlogContext")));
            services.AddDbContext<UnitOfWork>(options =>
                    options.UseMySql(Configuration.GetConnectionString("MyBlogContext")));

            services.AddControllersWithViews(options =>
            {
                //options.Filters.Add(new ValidateModelAttribute()); // an instance
                //options.Filters.Add(typeof(LoggerAttribute));
            }).AddRazorRuntimeCompilation();


            ////Custom Exception and validation Filter
            //services.AddScoped<CustomExceptionFilterAttribute>();


            //Repositories
            services.AddScoped<IBlogRepository, BlogRepository>();


            //DomainServices
            services.AddScoped<IBlogDomainService, BlogDomainService>();

            //AppServices
            services.AddScoped<IBlogAppService, BlogAppService>();

            //Adapters
            services.AddAutoMapper();
            services.AddScoped<ITypeAdapterFactory, AutomapperTypeAdapterFactory>();
            TypeAdapterFactory.SetCurrent(services.BuildServiceProvider().GetService<ITypeAdapterFactory>());

            //Validator
            EntityValidatorFactory.SetCurrent(new DataAnnotationsEntityValidatorFactory());

            //Localization
            LocalizationFactory.SetCurrent(new ResourcesManagerFactory());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //app.addu

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=Index}/{id?}");
            });
        }
    }
}
