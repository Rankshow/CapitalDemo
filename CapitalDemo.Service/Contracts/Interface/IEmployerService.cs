using CapitalDemo.Service.Contracts.Dtos;
using CapitalDemo.Service.Contracts.Request;
using CapitalDemo.Service.Contracts.Response;

namespace CapitalDemo.Service.Contracts.Interface;

public interface IEmployerService
{
    Task<EmployerRsp<EmployerDto>> CreateAsync(CreateEmployerReq req);
    Task<EmployerRsp<EmployerDto>> UpdateAsync(UpdateEmployerReq req);
}
