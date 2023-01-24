using System.Data.SqlClient;
using Uitls;

namespace AdoNetPractice
{
    public class OrdersRepository
    {
        public Order GetOrderById(int orderId)
        {
            Order order = new Order();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();
                SqlCommand readOrders = new SqlCommand($"SELECT * FROM Orders WHERE Id={orderId}", conn);
                SqlDataReader orders = readOrders.ExecuteReader();

                while (orders.Read())
                {
                    order = new Order
                    {
                        Id = (int)orders["Id"],
                        NumberOfPieces = (int)orders["NumberOfPieces"],
                        ItemId = (int)orders["ItemId"],
                    };
                }
            }

            return order;
        }
    }
}
