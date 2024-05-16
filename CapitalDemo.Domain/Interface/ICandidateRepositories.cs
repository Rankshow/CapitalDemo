using CapitalDemo.Domain.Models;

namespace CapitalDemo.Domain.Interface;

public interface ICandidateRepositories
{
    Task<List<Candidate>> GetAllAsync();
    Task<Candidate> CreateAsync(Candidate candidate);
}
