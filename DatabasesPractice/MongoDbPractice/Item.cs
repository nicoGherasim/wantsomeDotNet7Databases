using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace MongoDbPractice
{
    public class Item
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))] // attribute used to derermine MongoDB driver to generate the IDs for this collection
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}
