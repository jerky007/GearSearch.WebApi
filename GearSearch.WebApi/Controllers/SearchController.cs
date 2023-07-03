using GearSearch.WebApi.DomainObjects;
using Microsoft.AspNetCore.Mvc;

namespace GearSearch.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {

        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Search")]
        public IEnumerable<WeaponItem> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeaponItem
            {
                
            })
            .ToArray();
        }
    }
}