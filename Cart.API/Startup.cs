#region References
using System;
using System.Collections.Generic;
using Cart.Business.Managers;
using Cart.Business.Mappers;
using Cart.Common.Common;
using Cart.Contracts.Common;
using Cart.Contracts.Managers;
using Cart.Contracts.Repositories.OrderRepo;
using Cart.Contracts.Repositories.ProductRepo;
using Cart.Data.CartModels;
using Cart.Data.Mappers;
using Cart.Data.Repositories;
using Cart.Entities.Common;
using Cart.Resources;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
#endregion

#region Namespace
namespace Cart.API
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        private readonly IHostingEnvironment HostingEnvironment;
        public Startup(IHostingEnvironment hostEnvironment)
        {
            HostingEnvironment = hostEnvironment;

            var builder = new ConfigurationBuilder()
                .SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            #region Inject Context with sql server
            services.AddDbContext<ShoppingContext>(_cfg =>
            {
                _cfg.UseSqlServer(Configuration.GetConnectionString("ShoppingContext"));
            });
            #endregion

            #region Repositories
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            #endregion

            #region Managers
            services.AddScoped<IOrderManager, OrderManager>();
            services.AddScoped<IProductManager, ProductManager>();
            #endregion

            #region Error Handlers
            services.AddSingleton<IErrorMessagesHandler, ErrorMessageHandler>();
            #endregion

            #region Cors
            services.AddCors(options =>
            {
                options.AddPolicy("Default", _ =>
                {
                    _.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials().Build();
                });
            });
            #endregion

            #region Mappers
            services.AddSingleton<IMapper<IList<Message>, ServiceResponse>, ServiceErrorMapper>();
            services.AddSingleton<IMapper<Object, ServiceResponse>, ServiceResponseMapper>();
            services.AddSingleton<IEntityMapper, EntityMapper>();
            #endregion

            #region Utils
            services.AddSingleton<ICustomLogger, CoreLogger>();
            #endregion

            #region Response Compression
            services.AddResponseCompression(options =>
            {
                options.EnableForHttps = true;
                options.MimeTypes = new[]
                        {
                    // Default
                    "text/plain",
                    "text/css",
                    "application/javascript",
                    "text/html",
                    "application/xml",
                    "text/xml",
                    "application/json",
                    "text/json",
                    // Custom
                    "image/svg+xml",
                     "application/atom+xml"
                };
            });
            #endregion

            #region MVC
            services.AddMvc()
                 .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                 .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
            #endregion
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("Default");
            app.UseResponseCompression();
            app.UseMvc();
        }
    }
}
#endregion