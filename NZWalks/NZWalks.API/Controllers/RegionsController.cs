using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domains;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper) // injection of service into constructor of RegionsController class.
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet] 
        public async Task<IActionResult> GetAllRegions() // making it a type of Task to make it asynchronous.
        {
            var regions = await regionRepository.GetAllAsync();

            // return DTO regions object instead of Domain model to avoid any breaking changes
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
            //    };

            //    regionsDTO.Add(regionDTO);
            //});

            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }
    }
}
