// See https://aka.ms/new-console-template for more information
using DatabasesPractice.ADO.NET;

ItemsRepository itemsRepository = new ItemsRepository();

int numberOfItems = itemsRepository.GetNumberOfItems();
Console.WriteLine($"Number of items: {numberOfItems}");

Console.WriteLine("Items:");
List<Item> items = itemsRepository.GetAllItems();
foreach (Item item in items)
{
    Console.WriteLine($"{item.Id}, {item.Name}, {item.Price}");
}

Console.WriteLine("Orders:");
OrdersRepository ordersRepository = new OrdersRepository();

Order order = ordersRepository.GetOrderById(1);
Console.WriteLine($"{order.Id}, {order.NumberOfPieces}, {order.ItemId}");

order = ordersRepository.GetOrderById(2);
Console.WriteLine($"{order.Id}, {order.NumberOfPieces}, {order.ItemId}");
