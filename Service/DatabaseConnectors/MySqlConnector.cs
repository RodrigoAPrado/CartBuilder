using Service.Abstractions;
using Service.Models;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with mysql db.
    /// </summary>
    public class MySqlConnector : IDataBaseConnector
    {
        /// <inheritdoc/>
        public bool Search(SearchInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}