using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.DataAccess.Abstract;
using BlogApp.DataAccess.Concrete.EntitiyFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.API
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
            //cors
            services.AddCors();

            services.AddControllers();
           
            //injections
            services.AddSingleton<IHomeDal, EfHomeDal>();
            services.AddSingleton<IHomeService, HomePageManager>();
            services.AddSingleton<IFeatureDal, EfFeatureDal>();
            services.AddSingleton<IFeatureService, FeatureManager>();
            services.AddSingleton<IBackendPageDal, EfBackendPageDal>();
            services.AddSingleton<IBackendPageService, BackendPageManager>();
            services.AddSingleton<IBackendDal, EfBackendDal>();
            services.AddSingleton<IBackendService, BackendManager>();
            services.AddSingleton<IFrontendPageDal, EfFrontendPageDal>();
            services.AddSingleton<IFrontendPageService, FrontendPageManager>();
            services.AddSingleton<IFrontendDal, EfFrontendDal>();
            services.AddSingleton<IFrontendService, FrontendManager>();
            services.AddSingleton<IDatabasePageDal, EfDatabasePageDal>();
            services.AddSingleton<IDatabasePageService, DatabasePageManager>();
            services.AddSingleton<IDatabaseDal, EfDatabaseDal>();
            services.AddSingleton<IDatabaseService, DatabaseManager>();
            services.AddSingleton<IDevopsPageDal, EfDevopsPageDal>();
            services.AddSingleton<IDevopsPageService, DevopsPageManager>();
            services.AddSingleton<IDevopsService, DevopsManager>();
            services.AddSingleton<IDevopsDal, EfDevopsDal>();
            services.AddSingleton<IWorkPageService, WorkPageManager>();
            services.AddSingleton<IWorkPageDal, EfWorkPageDal>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //cors
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());




            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
