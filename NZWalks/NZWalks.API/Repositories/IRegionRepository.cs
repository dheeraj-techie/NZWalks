using NZWalks.API.Models.Domains;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync(); // define a contract to get regions from DB, defining a task type to make this method async.

        Task<Region> GetAsync(Guid id); // define a contract to fetch region by supplying id as an input parameter.

        Task<Region> AddAsync(Region region); // define a contract to add a region.

        Task<Region> DeleteAsync(Guid id); // define a contract to delete region by supplying id as an input parameter.

        Task<Region> UpdateAsync(Guid id, Region region);
    }
}
