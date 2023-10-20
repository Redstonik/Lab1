using Lab1.Contracts.Data;
using Lab1.Database.Data;
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
    }
}
