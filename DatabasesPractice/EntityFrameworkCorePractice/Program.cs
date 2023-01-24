using EntityFrameworkCorePractice;

Console.WriteLine("--- ITEMS REPO---");
ItemsRepository ir = new ItemsRepository();

Console.WriteLine();
Console.WriteLine("Read all items:");
ir.ReadAllItems();

Console.WriteLine();
Console.WriteLine("Read all items with orders:");
ir.ReadAllItemsWithOrders();

Console.WriteLine();
Console.WriteLine("Read first X items:");
ir.ReadFirstXItems(2);

Console.WriteLine();
Console.WriteLine("--- ORDERS REPO---");
OrdersRepository or = new OrdersRepository();

Console.WriteLine();
Console.WriteLine("Read all orders:");
or.ReadAllOrders();

Console.WriteLine();
or.UpdateFirstOrder();

Console.WriteLine();
Console.WriteLine("Read all orders after update:");
or.ReadAllOrders();

Console.WriteLine();
or.RemoveFirstOrder();

Console.WriteLine();
Console.WriteLine("Read all orders after delete:");
or.ReadAllOrders();