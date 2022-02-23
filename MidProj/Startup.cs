using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MidProj.Data;
using MidProj.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidProj
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepository, MyRepository>();

            string connectionStringMain = _configuration.GetConnectionString("DefaultConnectionMain");
            services.AddDbContext<ShopContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionStringMain));
            string connectionStringAccounts = _configuration.GetConnectionString("DefaultConnectionAccounts");
            services.AddDbContext<AuthenticationContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionStringAccounts));
            services.AddControllersWithViews();
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AuthenticationContext>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ShopContext ctx, AuthenticationContext ctx1)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            ctx1.Database.EnsureDeleted();
            ctx1.Database.EnsureCreated();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Home}/{id?}");
            });
        }
    }
}
