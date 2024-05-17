using CapitalDemo.Domain.Interface;
using CapitalDemo.Domain.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;
using Microsoft.Extensions.Configuration;
namespace CapitalDemo.Repository.Data;

public class CandidateRepositories : ICandidateRepositories
{
    private readonly CosmosClient _cosmosClient;
    private readonly IConfiguration _configuration;
    private readonly Container _candidateContainer;

    public CandidateRepositories(CosmosClient cosmosClient, IConfiguration configuration)
    {
        _configuration = configuration;
        _cosmosClient = cosmosClient;
        var databaseName = configuration["CosmosDbSettings:DatabaseName"];
        var candidateContainerName = "candidates";
        _candidateContainer = cosmosClient.GetContainer(databaseName, candidateContainerName);

    }
    public async Task<IEnumerable<Candidate>> GetAllCandidateAsync(string id)
    {
        var query = _candidateContainer.GetItemLinqQueryable<Candidate>()
                .Where(p => p.Id == id)
                .ToFeedIterator();
        var candidates = new List<Candidate>();

        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();
            candidates.AddRange(response);
        }
        return candidates;
    }
    public Task<Candidate> CreateCandidateAsync(Candidate candidate)
    {
        throw new NotImplementedException();
    }

}
