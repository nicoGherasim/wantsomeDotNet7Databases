using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDbPractice
{
    // In Mongo DB we don't need to have two different collections for items and orders
    // All the information can be stred in only one collection
    public class ItemsRepository
    {
        // The admin:admin part represents the username and the password
        MongoClient dbClient = new MongoClient("mongodb://admin:admin@localhost:27017/?authSource=admin");

        // this is the equivalent of DbSet<Item> from EF Core
        IMongoCollection<Item> items;

        public ItemsRepository()
        {
            IMongoDatabase db = dbClient.GetDatabase("ItemsManagement");
            items = db.GetCollection<Item>("Items");
        }


        public void InsertOneItem(Item item)
        {
            items.InsertOne(item);
        }

        public void InsertManyItems(List<Item> itemsToBeInserted)
        {
            items.InsertMany(itemsToBeInserted);
        }

        public void CountItems()
        {
            var numberOfItems = items.CountDocuments(new BsonDocument());
            Console.WriteLine("Number of items: " + numberOfItems);
        }

        public void GetAllItemsAsJson()
        {
            Console.WriteLine("All the items in the Items collection:");

            var allItems = items.Find(new BsonDocument()).ToList();
            // Newtonsoft.Json is used here to beautify the outpuot we display on the console
            // without it the indentation would not be done and it would be really hard to read
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(allItems, Newtonsoft.Json.Formatting.Indented);

            Console.WriteLine(json);
        }

        public void GetAllItems()
        {
            Console.WriteLine("All the items in the Items collection:");

            var allItems = items.Find(new BsonDocument()).ToList();
            DisplayAllItems(allItems);
        }

        public void GetItemsByFilter(FilterDefinition<Item> filter)
        {
            Console.WriteLine("Filtered items:");

            var itemsByFilter = items.Find(filter).ToList();
            DisplayAllItems(itemsByFilter);
        }

        public void GetSortedItems(SortDefinition<Item> sort)
        {
            Console.WriteLine("Sorted items:");

            var sortedItems = items.Find(new BsonDocument()).Sort(sort).ToList();
            DisplayAllItems(sortedItems);
        }
        public void UpdateManyItems(FilterDefinition<Item> filter, UpdateDefinition<Item> update)
        {

            items.UpdateMany(filter, update);
        }

        public void RemoveOneItem(FilterDefinition<Item> filter)
        {
            items.DeleteOne(filter);
        }

        private void DisplayAllItems(List<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine("Item: ");
                Console.WriteLine($"{item.Id}, {item.Name}, {item.Price}");
                Console.WriteLine("Orders: ");
                foreach (var order in item.Orders)
                {
                    // "\t" means Tab - moving the text one Tab to the right
                    Console.WriteLine($"\t{order.Id}, {order.NumberOfPieces}");
                }
            }
        }
        
    }
}
