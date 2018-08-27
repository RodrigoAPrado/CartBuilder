using MongoDB.Driver;
using Service.Abstractions;
using Service.Models;

namespace Service.Facades
{
    /// <inheritdoc />
    public class DefaultSearchFacade : ISearchFacade
    {
        private IDataBaseConnector databaseConnector;
        
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