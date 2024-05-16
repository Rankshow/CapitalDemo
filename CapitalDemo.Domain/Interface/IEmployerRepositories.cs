using CapitalDemo.Domain.Models;

namespace CapitalDemo.Domain.Interface;

public interface IEmployerRepositories
{
    Task<Employer> CreateAsync(Employer employer);
    Task<Employer> UpdateAsync(string id, Employer employer);
}
