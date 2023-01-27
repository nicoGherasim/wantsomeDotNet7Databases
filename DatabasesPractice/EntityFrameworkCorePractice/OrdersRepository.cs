namespace EntityFrameworkCorePractice
{
    public class OrdersRepository
    {
        public void ReadAllOrders()
        {
            // write the corresponding code to get all the orders
            using (var context = new ItemsManagementContext())
            {
                var orders = context.Orders.ToList();
                foreach (var order in orders)
                {
                    Console.WriteLine($"{order.Id}, {order.NumberOfPieces}");
                }
            }
        }

        public void UpdateFirstOrder()
        {
            // write the corresponding code to update the first order
            // Tip. .First() method should help you
            // Don't forget to save your changes with context.SaveChanges();
            using (var context = new ItemsManagementContext())
            {
                var dbOrder = context.Orders.First();

                dbOrder.NumberOfPieces = 215;

                context.Orders.Update(dbOrder);
                context.SaveChanges();
            }
        }

        public void RemoveFirstOrder()
        {
            // write the corresponding code to remove the first order
            // Tip. .First() method should help you
            // Don't forget to save your changes with context.SaveChanges();
            using (var context = new ItemsManagementContext())
            {
                var dbOrder = context.Orders.First();

                context.Orders.Remove(dbOrder);
                context.SaveChanges();
            }
        }
    }
}
