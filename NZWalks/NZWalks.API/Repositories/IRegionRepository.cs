using NZWalks.API.Models.Domains;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync(); // define a contract to get regions from DB, defining a task type to make this method async.
    }
}
