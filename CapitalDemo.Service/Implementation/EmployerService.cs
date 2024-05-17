using CapitalDemo.Domain.Interface;
using CapitalDemo.Service.Contracts.Dtos;
using CapitalDemo.Service.Contracts.Extension;
using CapitalDemo.Service.Contracts.Interface;
using CapitalDemo.Service.Contracts.Request;
using CapitalDemo.Service.Contracts.Response;

namespace CapitalDemo.Service.Implementation;

public class EmployerService : IEmployerService
{
    private readonly IEmployerRepositories _employerRepositories;
    public EmployerService(IEmployerRepositories employerRepositories)
    {
        _employerRepositories = employerRepositories;        
    }
    public EmployerRsp<EmployerDto> CreateAsync(CreateEmployerReq req)
    {
        var createEmployer = req.AsEntity();
        _employerRepositories.CreateAsync(createEmployer);
        return new EmployerRsp<EmployerDto>
        {
            Message = "Success",
            Code = "200"
        };
    }

    public async Task<EmployerRsp<EmployerDto>> UpdateAsync(UpdateEmployerReq req)
    {
        var updateEmployer = req.AsEntity();
        await _employerRepositories.UpdateAsync(updateEmployer);
        return new EmployerRsp<EmployerDto>
        {
            Message = "Success",
            Code = "200"
        };
    }
}
