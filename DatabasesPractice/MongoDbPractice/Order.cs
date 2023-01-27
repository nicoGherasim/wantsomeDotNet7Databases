using MongoDB.Bson;

namespace MongoDbPractice
{
    public class Order
    {
        public ObjectId Id { get; set; }
        public int NumberOfPieces { get; set; }

        public Order()
        {
            // For embedded resources (order embedded inside item), MongoDb driver does not automatically generate IDs (even if we use the special attribute that should)
            // So we have to take care of this action by creating a new ID in the constructor of the class
            Id = ObjectId.GenerateNewId();
        }
    }
}
