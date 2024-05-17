using CapitalDemo.Domain.Interface;
using CapitalDemo.Domain.Models;
using CapitalDemo.Service.Contracts.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerRepositories _employerRepositories;
        public EmployerController(IEmployerRepositories employerRepositories)
        {
            _employerRepositories = employerRepositories;   
        }

        [HttpGet("candidate/{candidateId}")]
        public async Task<ActionResult<IEnumerable<Employer>>> GetAllAsync(string candidateId)
        {
            var allCandidates = await _employerRepositories.GetAllCandidateAsync(candidateId);
            return Ok(allCandidates);
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponse>> CreateAsync([FromQuery] Employer employer)
        {
            var addCandidate = await _employerRepositories.CreateAsync(employer);
            return Ok(addCandidate);
        }
    }
}
