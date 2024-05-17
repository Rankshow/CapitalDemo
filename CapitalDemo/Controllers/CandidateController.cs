using CapitalDemo.Domain.Interface;
using CapitalDemo.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalDemo.Controllers
{
    [Route("api/candidates")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateRepositories _candidateRepositories;
        public CandidateController(ICandidateRepositories candidateRepositories)
        {
            _candidateRepositories = candidateRepositories;
        }

        [HttpGet("candidate/{id}")]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetAllCandidate(string id)
        {
            var allCandidate = await _candidateRepositories.GetAllCandidateAsync(id);
            return Ok(allCandidate);
        }
        
    }
}
