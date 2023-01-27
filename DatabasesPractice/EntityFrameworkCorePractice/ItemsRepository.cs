using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCorePractice
{
    public class ItemsRepository
    {
        public void ReadAllItems()
        {
            using (var context = new ItemsManagementContext())
            {
                // write the corresponding code to get all items
                var items = context.Items.ToList();
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Id}, {item.Name}, {item.Price}");
                }
            }
        }

        public void ReadAllItemsWithOrders()
        {
            using (var context = new ItemsManagementContext())
            {
                var items = context.Items.Include(i => i.Orders).ToList();

                // write the corresponding code to display the items with their orders
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Id}, {item.Name}, {item.Price}");
                    Console.WriteLine("Orders: ");
                    foreach (var order in item.Orders)
                    {
                        Console.WriteLine($"{order.Id}, {order.NumberOfPieces}");
                    }
                }
            }
        }

        public void ReadFirstXItems(int numberOfItemsToRead)
        {
            // write the corresponding code to get the first X items
            // Tip. .Take(number) method should help you
            using (var context = new ItemsManagementContext())
            {
                var items = context.Items.Take(numberOfItemsToRead).ToList();
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Id}, {item.Name}, {item.Price}");
                }
            }
        }
    }
}
