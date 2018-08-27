using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Service.Abstractions;
using Service.Models;
using Service.Models.Database;
using Service.Models.Mongo;

namespace Service.DatabaseConnectors
{
    /// <summary>
    /// Defines database connection with mongo db.
    /// </summary>
    public class MongoDbConnector : IDatabaseConnector
    {
        private readonly IMongoDatabase db;
        private readonly IMongoCollection<ProductMongo> productCollection;

        /// <summary>
        /// Initiates a new instance of <see cref="MongoDbConnector"/>.
        /// </summary>
        /// <param name="config">Connection configuration.</param>
        public MongoDbConnector(DatabaseConnectionConfig config)
        {
            var client = new MongoClient(new MongoUrl(config.Connection));
            db = client.GetDatabase(config.DatabaseName);
            productCollection = db.GetCollection<ProductMongo>("products");
            FilterDefinition<ProductMongo> filter = FilterDefinition<ProductMongo>.Empty;
            var teste = productCollection.FindSync(filter).ToList();
        }

        public QueryResult<IProduct> Search(SearchInput input)
        {
            return null;
        }
    }
}