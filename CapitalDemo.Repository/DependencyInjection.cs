using CapitalDemo.Domain.Interface;
using CapitalDemo.Repository.Data;
using Microsoft.Extensions.DependencyInjection;
namespace CapitalDemo.Repository;

public static class DependencyInjection
{
    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddScoped<ICandidateRepositories, CandidateRepositories>();
        services.AddScoped<IEmployerRepositories, EmployerRepositories>();
        
        return services;

    }
}
