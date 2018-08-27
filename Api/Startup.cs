using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Service.Abstractions;
using Service.Models;
using Service.Utils;

namespace CartBuilder
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
            GetDbConnector(services);
            GetFacades(services);
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private static void GetDbConnector(IServiceCollection services)
        {
            var configJson = System.IO.File.ReadAllText(ConfigConstants.DatabaseConfigPath);
            var configModel = JsonConvert.DeserializeObject<DatabaseConnectionConfig>(configJson);
            var connectorType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IDataBaseConnector).IsAssignableFrom(p) 
                            && !p.IsInterface 
                            && !p.IsAbstract
                            && p.Name.ToLower().StartsWith(configModel.Type))
                .ToList().First();
            
            services.AddSingleton<IDataBaseConnector>((IDataBaseConnector)
                Activator.CreateInstance(connectorType, configModel));
        }

        private static void GetFacades(IServiceCollection services)
        {
            var configJson = System.IO.File.ReadAllText(ConfigConstants.FacadeConfigPath);
            var configModel = JsonConvert.DeserializeObject<FacadeUsageConfig>(configJson);
            var facadeInterfaces = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IFacade).IsAssignableFrom(p)
                            && p.IsInterface
                            && p.Name != typeof(IFacade).Name).ToList();
            
            foreach (var facadeInterface in facadeInterfaces)
            {
                var facadeClasses = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => facadeInterface.IsAssignableFrom(p)
                                && !p.IsInterface
                                && !p.IsAbstract)
                    .ToList();
                var facadeType = facadeClasses.Find(s => s.Name.ToLower().StartsWith(configModel.Type));
                if (facadeType == null) 
                    facadeType = facadeClasses.Find(s => s.Name.ToLower()
                        .StartsWith(InstantiationConstants.DefaultConstant));
                services.AddSingleton(facadeInterface, facadeType);
            }
        }
    }
}
