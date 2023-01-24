using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCorePractice
{
    public class ItemsRepository
    {
        public void ReadAllItems()
        {
            using (var context = new ItemsManagementContext())
            {

                //TO DO
                // write the corresponding code to get all items
            }
        }

        public void ReadAllItemsWithOrders()
        {
            using (var context = new ItemsManagementContext())
            {
                var items = context.Items.Include(i => i.Orders).ToList();

                //TO DO
                // write the corresponding code to display the items with their orders
            }
        }

        public void ReadFirstXItems(int numberOfItemsToRead)
        {
            //TO DO
            // write the corresponding code to get the first X items
            // Tip. .Take(number) method should help you
        }
    }
}
