using MongoDB.Driver;
using Service.Abstractions;
using Service.Models;

namespace Service.Facades
{
    /// <inheritdoc />
    public class DefaultSearchFacade : ISearchFacade
    {
        private readonly IDataBaseConnector databaseConnector;
        
        /// <summary>
        /// Initiates a new instance of <see cref="DefaultSearchFacade"/>.
        /// </summary>
        /// <param name="databaseConnector">Database connector to be used.</param>
        public DefaultSearchFacade(IDataBaseConnector databaseConnector)
        {
            this.databaseConnector = databaseConnector;
        }
        
        /// <inheritdoc/>
        public bool Search(SearchInput input)
        {
            return databaseConnector.Search(input);
        }
    }
}