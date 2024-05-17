using CapitalDemo.Domain.Interface;
using CapitalDemo.Domain.Models;
using CapitalDemo.Repository.Enum;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using Microsoft.Extensions.Configuration;

namespace CapitalDemo.Repository.Data;

public class EmployerRepositories : IEmployerRepositories
{
    private readonly CosmosClient _cosmosClient;
    private readonly IConfiguration _configuration;
    private readonly Container _employerContainer;
    public EmployerRepositories(CosmosClient cosmosClient, IConfiguration configuration)
    {
        _configuration = configuration;
        _cosmosClient = cosmosClient;
        var databaseName = configuration["CosmosDbSettings:DatabaseName"];
        var employerContainerName = "Employers";
        _employerContainer = cosmosClient.GetContainer(databaseName, employerContainerName);    
    }

    public async Task<IEnumerable<Employer>> GetAllCandidateAsync(string candidateId)
    {
        var query =  _employerContainer.GetItemLinqQueryable<Employer>()
            .Where(s => s.Id == candidateId)
            .ToFeedIterator();
        var employers =new List<Employer>();

        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();
            employers.AddRange(response);
        }
        return employers;

    }
    public async Task<Employer> CreateAsync(Employer employer)
    {
        employer.YearOfGraduation = ((int)YearOfGraduationEnum.Default);
        return await _employerContainer.CreateItemAsync(employer);
    }

    //public Task<Employer> CreateAsync(Employer employer)
    //{
    //    throw new NotImplementedException();
    //}


    public Task<Employer> UpdateAsync(Employer employer)
    {
        throw new NotImplementedException();
    }
}
