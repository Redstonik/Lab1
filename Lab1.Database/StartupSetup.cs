using Lab1.Contracts.Data;
using Lab1.Contracts.Data.Entities;
using Lab1.Database.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1.Database
{
    public static class StartupSetup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
        public static void AddDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<Lab1DbContext>(x => x.UseSqlServer(connectionString));
        }
        public static void AddIdentityDbContext(this IServiceCollection services)
        {
            services.AddIdentity<User,
            IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<Lab1DbContext>()
            .AddDefaultTokenProviders();
        }
        //public static void AddAutoMapper(this IServiceCollection services)
        //{
        //    var mapperConfig = new MapperConfiguration(mc =>
        //    {
        //        mc.AddProfile(new ApplicationProfile());
        //    });
        //    IMapper mapper = mapperConfig.CreateMapper();
        //    services.AddSingleton(mapper);
        //}
    }
}

