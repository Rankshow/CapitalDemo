using CapitalDemo.Domain.Models;

namespace CapitalDemo.Domain.Interface;

public interface IEmployerRepositories
{
    Task<Employer> CreateAsync(Employer employer);
    Task<IEnumerable<Employer>> GetAllCandidateAsync(string candidateId);
    Task<Employer> UpdateAsync(Employer employer);
}
