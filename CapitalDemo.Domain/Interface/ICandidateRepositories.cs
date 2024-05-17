using CapitalDemo.Domain.Models;

namespace CapitalDemo.Domain.Interface;

public interface ICandidateRepositories
{
    Task<IEnumerable<Candidate>> GetAllCandidateAsync(string id);
    Task<Candidate> CreateCandidateAsync(Candidate candidate);
}
