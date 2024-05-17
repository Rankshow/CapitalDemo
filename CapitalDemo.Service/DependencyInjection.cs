using CapitalDemo.Service.Contracts.Interface;
using CapitalDemo.Service.Contracts.Request;
using CapitalDemo.Service.Implementation;
using CapitalDemo.Service.Validation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CapitalDemo.Service;

public static class DependencyInjection
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddScoped<IEmployerService, EmployerService>();
        services.AddScoped<ICandidateService, CandidateService>();
        services.AddScoped<IValidator<CreateEmployerReq>, CreateEmployerValidation>();
        //services.AddScoped<IValidator<UpdateEmployerReq>, UpdateEmployerValidation>();
        return services;
    }
}
