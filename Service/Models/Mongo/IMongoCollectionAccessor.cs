using MongoDB.Driver;
using Service.Models.Database;

namespace Service.Models.Mongo
{
    public interface IMongoCollectionAccessor<T> : IDatabaseDataAccessor<IMongoCollection<T>>
    {
        
    }
}