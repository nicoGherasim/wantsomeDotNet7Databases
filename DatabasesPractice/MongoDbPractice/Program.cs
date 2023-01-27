using MongoDB.Driver;
using MongoDbPractice;

ItemsRepository ir = new ItemsRepository();

var item = new Item
{
    Name = "Apple",
    Price = 10,
    Orders = new List<Order> { 
        new Order { NumberOfPieces = 5 },
        new Order { NumberOfPieces = 12 }
    }
};
ir.InsertOneItem(item);

var items = new List<Item> {
 new Item
{
    Name = "Banana",
    Price = 12,
    Orders = new List<Order> {
        new Order { NumberOfPieces = 12 },
        new Order { NumberOfPieces = 23 }
    }
},
 new Item
{
    Name = "Mango",
    Price = 20,
    Orders = new List<Order> {
        new Order { NumberOfPieces = 3 }
    }
}};

ir.InsertManyItems(items);

ir.GetAllItemsAsJson();

Console.WriteLine();
ir.GetAllItems();

Console.WriteLine();
ir.CountItems();

Console.WriteLine();
// build a filter for all the items that have the Price GT (greater than) 10
var filter = Builders<Item>.Filter.Gt("Price", 10);
ir.GetItemsByFilter(filter);

Console.WriteLine();
// build a sorting criterion
var sort = Builders<Item>.Sort.Descending("Price");
ir.GetSortedItems(sort);

Console.WriteLine();
// build a filter for all the items that have the Price LTE (lower or equal than) 10
filter = Builders<Item>.Filter.Lte("Price", 10);
// build an update for all the items to have the Price set as 300
var update = Builders<Item>.Update.Set("Price", 300);
ir.UpdateManyItems(filter, update);
ir.GetAllItems();

Console.WriteLine();
// build a filter for all the items that have the Price EQ (equal to) 300
filter = Builders<Item>.Filter.Eq("Price", 300);
// remove the first item that matches the filter
ir.RemoveOneItem(filter);

ir.GetAllItems();

