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
                // write the corresponding code to get the number of items
                conn.Open();
                SqlCommand readNumberOfItems = new SqlCommand("SELECT COUNT(*) FROM Items", conn);
                numberOfItems = (int)readNumberOfItems.ExecuteScalar();
            }
            return numberOfItems;
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            // write the corresponding code to get  all the items
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                SqlCommand readAllItems = new SqlCommand("SELECT * FROM Items", conn);
                SqlDataReader allItems = readAllItems.ExecuteReader();

                while (allItems.Read())
                {
                    var item = new Item
                    {
                        Id = (int)allItems["Id"],
                        Name = (string)allItems["Name"],
                        Price = (int)allItems["Price"],
                    };
                    items.Add(item);
                }
            }

            return items;
        }
    }
}
