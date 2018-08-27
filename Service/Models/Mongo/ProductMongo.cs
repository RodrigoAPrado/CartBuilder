using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Service.Models.Database;

namespace Service.Models.Mongo
{
    /// <summary>
    /// Defines a product from a mongo db.
    /// </summary>
    [DataContract]
    public class ProductMongo : IProduct
    {
        /// <summary>
        /// Mongo db object id.
        /// </summary>
        [BsonId]
        [DataMember(Name = "_id")]
        public ObjectId Id { get; set; }
        
        /// <inheritdoc/>
        [DataMember(Name = "name")]
        [BsonElement("name")]
        public string Name { get; set; }
    }
}