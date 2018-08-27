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
        private const string defaultConnectionString = "mongodb://localhost:27017";
        private const string defaultDataBaseName = "cart_builder";
        private IMongoDatabase db;

        public MongoDbConnector()
        {
            var client = new MongoClient(defaultConnectionString);
            db = client.GetDatabase(defaultDataBaseName);
        }

        public MongoDbConnector(IMongoClient client)
        {
            db = client.GetDatabase(defaultDataBaseName);
        }

        public MongoDbConnector(IMongoDatabase db)
        {
            this.db = db;
        }

        public MongoDbConnector(string connectionString)
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(defaultDataBaseName);
        }

        public MongoDbConnector(string connectionString, string dataBaseName)
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(dataBaseName);
        }

        public bool Search(SearchInput input)
        {
            return false;
        }
    }
}