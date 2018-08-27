using MongoDB.Driver;

namespace Service.Models.Mongo
{
    public class ProductCollectionAccessor : IMongoCollectionAccessor<ProductMongo>
    {
        public IMongoCollection<ProductMongo> Data { get; set; }
    }
}