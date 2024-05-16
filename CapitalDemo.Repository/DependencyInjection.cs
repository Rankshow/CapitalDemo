using CapitalDemo.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CapitalDemo.Repository;

public static class DependencyInjection
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<ICandidateRepositories, ICandidateRepositories>();
        services.AddScoped<IEmployerRepositories, IEmployerRepositories>();
        
        return services;

    }
}
