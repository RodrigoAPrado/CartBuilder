using MongoDB.Driver;
using Service.Abstractions;
using Service.Models;
using Service.Models.Database;
using Service.Models.Mongo;

namespace Service.Facades
{
    /// <inheritdoc />
    public class DefaultSearchFacade : ISearchFacade
    {
        private readonly IDatabaseConnector databaseConnector;
        private const string collectionName = "products";
        
        /// <summary>
        /// Initiates a new instance of <see cref="DefaultSearchFacade"/>.
        /// </summary>
        /// <param name="databaseConnector">Database connector to be used.</param>
        public DefaultSearchFacade(IDatabaseConnector databaseConnector)
        {
            this.databaseConnector = databaseConnector;
        }
        
        /// <inheritdoc/>
        public QueryResult<IProduct> Search(SearchInput input)
        {
            return databaseConnector.Search(input);
        }
    }
}