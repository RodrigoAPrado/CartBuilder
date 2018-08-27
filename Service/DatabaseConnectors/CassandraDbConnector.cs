using Service.Abstractions;
using Service.Models;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with cassandra.
    /// </summary>
    public class CassandraDatabaseConnector : IDataBaseConnector
    {
        /// <inheritdoc/>
        public bool Search(SearchInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}