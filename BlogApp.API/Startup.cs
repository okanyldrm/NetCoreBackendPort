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
using Autofac;
using BlogApp.API.Dependency;
using BlogApp.DataAccess.Authentication;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;

using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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

            services.AddControllers().AddNewtonsoftJson();


            //Entity Framework
            services.AddDbContext<ApplicationDbContext>(option =>
                option.UseNpgsql(Configuration.GetConnectionString("ConStr")));


            //For Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            //Adding Authentication
            services.AddAuthentication(option =>
                {
                    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                //Adding Jwt Bearer

                .AddJwtBearer(option =>
                {
                    option.SaveToken = true;
                    option.RequireHttpsMetadata = false;
                    option.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = false,
                        ValidAudience = Configuration["JWT:ValidAudience"],
                        ValidIssuer = Configuration["JWT:ValidIssuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                    };
                });




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
            services.AddSingleton<IWorkService, WorkManager>();
            services.AddSingleton<IWorkDal, EfWorkDal>();
            services.AddSingleton<IAboutPageService, AboutPageManager>();
            services.AddSingleton<IAboutPageDal, EfAboutPageDal>();
            services.AddSingleton<IBlogPageService, BlogPageManager>();
            services.AddSingleton<IBlogPageDal, EfBlogPageDal>();
            services.AddSingleton<IBlogService, BlogManager>();
            services.AddSingleton<IBlogDal, EfBlogDal>();
            services.AddSingleton<IEventDal, EfEventDal>();
            //services.AddSingleton<IEventService, EventManager>();
            services.AddOptions();

        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DependencyRegister());
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
            app.UseAuthentication();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
