using Microsoft.AspNetCore.Mvc;
using Service.Abstractions;
using Service.Models;

namespace Api.Controllers
{
    /// <summary>
    /// Defines a controller to be used for searches.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : Controller
    {
        private ISearchFacade searchFacade;
        
        public SearchController(ISearchFacade searchFacade)
        {
            this.searchFacade = searchFacade;
        }
        
        // POST api/values
        [HttpPost]
        public bool Search([FromBody] SearchInput value)
        {
            return searchFacade.Search(value);
        }
    }
}