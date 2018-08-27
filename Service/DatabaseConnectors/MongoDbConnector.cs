using MongoDB.Bson;
using MongoDB.Driver;
using Service.Abstractions;
using Service.Models;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with mongo db.
    /// </summary>
    public class MongoDbConnector : IDataBaseConnector
    {
        private readonly IMongoDatabase db;

        /// <summary>
        /// Initiates a new instance of <see cref="MongoDbConnector"/>.
        /// </summary>
        /// <param name="config">Connection configuration.</param>
        public MongoDbConnector(DatabaseConnectionConfig config)
        {
            var client = new MongoClient(config.Connection);
            db = client.GetDatabase(config.DatabaseName);
        }

        public bool Search(SearchInput input)
        {
            return false;
        }
    }
}