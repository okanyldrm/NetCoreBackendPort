using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.DataAccess.Abstract;
using BlogApp.DataAccess.Concrete.EntitiyFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.WebUI
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

           //services.AddDbContext<PostgreSqlDbContext>(option=>option.UseNpgsql());



            services.AddRazorPages();
            services.AddMvc();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //PostgreSql Default
            services.AddDbContext<BlogContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnectionString"), b=>b.MigrationsAssembly("BlogApp.WebUI")));
            services.AddScoped<DbContext>(provider => provider.GetService<BlogContext>());


            //DI
            services.AddSingleton<IBannerDal,EfBannerDal>();
            services.AddSingleton<IBannerService, BannerManager>();

            services.AddSingleton<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICategoryService, CategoryManager>();

            services.AddSingleton<IProjectDal, EfProjectDal>();
            services.AddSingleton<IProjectService, ProjectManager>();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
         
            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
