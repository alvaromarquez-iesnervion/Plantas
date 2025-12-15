using Data.repos;
using Domain.Interfaces;
using Domain.Repos;
using Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace CompositionRoot
{
    public static class Container
    {
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services)
        {

            // Registrar repositorios
            services.AddScoped<IPlantRepository, PlantRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            // Registrar casos de uso
            services.AddScoped<IPlantsUseCase, PlantsUseCase>();


            return services;
        }
    }
}
