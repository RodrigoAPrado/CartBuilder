using Service.Models;

namespace Service.Abstractions
{
    /// <summary>
    /// Defines a common search facade.
    /// </summary>
    public interface ISearchFacade : IFacade
    {
        /// <summary>
        /// Executes and work with a query in database.
        /// </summary>
        /// <param name="input">Input for search.</param>
        /// <returns>Search results.</returns>
        bool Search(SearchInput input);
    }
}