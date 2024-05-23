using CapitalDemo.Domain.Interface;
using CapitalDemo.Domain.Models;
using CapitalDemo.Service.Contracts.Interface;
using CapitalDemo.Service.Contracts.Request;
using CapitalDemo.Service.Contracts.Response;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalDemo.Controllers
{
    [Route("api/employers")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerRepositories _employerRepositories;
        //private readonly IEmployerService _employerService;
        //private readonly IValidator<CreateEmployerReq> _validator;
        public EmployerController(IEmployerRepositories employerRepositories /*IValidator<CreateEmployerReq> validator*/)
        {
            _employerRepositories = employerRepositories;
            //_validator = validator;
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponse>> CreateAsync([FromQuery]  Employer employer)
        {
            var addEmployer = await _employerRepositories.CreateAsync(employer);
            return Ok(addEmployer);
        }

        //[HttpGet("candidate/{candidateId}")]
        //public async Task<ActionResult<IEnumerable<Employer>>> GetAllAsync(string candidateId)
        //{
        //    var allCandidates = await _employerService.GetAllAsync(candidateId);
        //    return Ok(allCandidates);
        //}

        //[HttpPost]
        //public async Task<ActionResult<BaseResponse>> CreateAsync([FromQuery] CreateEmployerReq req)
        //{
        //    var addEmp = await _employerService.CreateAsync(req);
        //    return Ok(addEmp);
        //}
    }
}
