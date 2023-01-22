using System.Data.SqlClient;

namespace DatabasesPractice.ADO.NET
{
    public class ItemsRepository
    {
        string connectionString = "Server=localhost;Database=ItemsManagement;User Id=sa;Password=<YOUR_PASSWORD>;";

        public int GetNumberOfItems()
        {
            int numberOfItems = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
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
