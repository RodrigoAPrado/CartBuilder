using Service.Abstractions;
using Service.Models;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with lite db.
    /// </summary>
    public class LiteDbConnector : IDataBaseConnector
    {
        /// <inheritdoc/>
        public bool Search(SearchInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}