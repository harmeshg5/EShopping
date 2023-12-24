using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Catalog.API
{
    public class Startup
    {
        public readonly IConfiguration configuration;

        public Startup(IConfiguration _configuration)
        {
            configuration = _configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }


    }
}
