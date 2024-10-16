using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AppCrudUsuarios.Data;

namespace AppCrudUsuarios.Infrastructure
{
    public static class DbConnectionConfig
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
