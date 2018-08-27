using Service.Abstractions;
using Service.Models;
using Service.Models.Database;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with lite db.
    /// </summary>
    public class LiteDbConnector : IDatabaseConnector
    {
        /// <inheritdoc/>
        public QueryResult<IProduct> Search(SearchInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}