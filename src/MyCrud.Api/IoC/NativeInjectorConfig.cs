using Microsoft.EntityFrameworkCore;
using MyCrud.Data.Context;
using MyCrud.Data.Repositories;
using MyCrud.Domain.Interfaces.Repositories;
using MyCrud.Domain.Interfaces.Services;
using MyCrud.Domain.Services;

namespace MyCrud.Api.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //var connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DATABASE_CONNECTION_STRING")));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
