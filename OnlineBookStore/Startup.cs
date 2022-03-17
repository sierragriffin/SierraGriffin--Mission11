﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineBookStore.Models;

namespace OnlineBookStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup (IConfiguration temp)
        {
            Configuration = temp;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //service that tells ASP.NET to use the MVC setup
            //necessary for the MVC pattern to be recognized
            services.AddControllersWithViews();

            services.AddDbContext<BookstoreContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:BookDBConnection"]);
            });

            services.AddDbContext<AppIdentityDBContext>(options =>
                options.UseSqlite(Configuration["ConnectionStrings:IdentityConnection"]));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDBContext>();

            services.AddScoped<IBookStoreRepository, EFBookStoreRepository>();
            services.AddScoped<IPurchaseRepository, EFPurchaseRepository>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();

            services.AddSession();

            services.AddScoped<Cart>(x => SessionCart.GetCart(x));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //tells ASP.NET to use the files in the wwwroot folder
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //user-friendly endpoints
            //order matters!
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "categorypage",
                    pattern: "{bookCategory}/Page{pageNum}",
                    defaults: new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "paging",
                    pattern: "Page{pageNum}",
                    defaults: new { Controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapControllerRoute(
                    name: "category",
                    pattern: "{bookCategory}",
                    defaults: new { Controller = "Home", action = "Index", pageNum = 1 });

                //controller first, then action, then id
                //endpoints.MapControllerRoute(
                //    name : "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}")

                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();

                endpoints.MapBlazorHub(); //Middleware

                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
            });

            IdentitySeedData.EnsurePopulated(app);

        }
    }
}
