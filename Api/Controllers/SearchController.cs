using Microsoft.AspNetCore.Mvc;
using Service.Abstractions;
using Service.Models;
using Service.Models.Database;

namespace Api.Controllers
{
    /// <summary>
    /// Defines a controller to be used for searches.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : Controller
    {
        private readonly ISearchFacade searchFacade;
        
        public SearchController(ISearchFacade searchFacade)
        {
            this.searchFacade = searchFacade;
        }
        
        // POST api/values
        [HttpPost]
        public QueryResult<IProduct> Search([FromBody] SearchInput value)
        {
            return searchFacade.Search(value);
        }
    }
}