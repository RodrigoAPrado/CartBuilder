using Service.Abstractions;
using Service.Models;
using Service.Models.Database;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with mysql db.
    /// </summary>
    public class MySqlConnector : IDatabaseConnector
    {
        /// <inheritdoc/>
        public QueryResult<IProduct> Search(SearchInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}