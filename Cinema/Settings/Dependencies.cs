using Cinema.DTO;
using Cinema.Entities;
using Cinema.Mapping;
using Cinema.Repositories;
using Cinema.Services;
using System;

namespace Cinema.Settings
{
    public class Dependencies
    {
        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            applicationBuilder.Services.AddDbContext<MovieContext>();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }
        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<MovieService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<MoviesRepostories>();
        }
    }
}
