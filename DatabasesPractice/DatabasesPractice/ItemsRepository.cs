using System.Data.SqlClient;
using Uitls;

namespace AdoNetPractice
{
    public class ItemsRepository
    {
        public int GetNumberOfItems()
        {
            int numberOfItems = 0;
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                //TO DO
                // write the corresponding code to get the number of items
            }
            return numberOfItems;
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            //TO DO
            // write the corresponding code to get  all the items

            return items;
        }
    }
}
