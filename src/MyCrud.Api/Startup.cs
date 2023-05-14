using MyCrud.Api.Extensions;
using MyCrud.Api.IoC;

namespace MyCrud.Api
{
    public class Startup : Interfaces.IStartup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddSwagger();
            services.AddVersioning();
            services.RegisterServices(Configuration);
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.UseSwaggerUi();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            app.UseStaticFiles();
        }
    }
}
