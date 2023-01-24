using System.Data.SqlClient;

namespace DatabasesPractice.ADO.NET
{
    public  class OrdersRepository
    {
        string connectionString = "Server=localhost;Database=ItemsManagement;User Id=sa;Password=<YOUR_PASSWORD>;TrustServerCertificate=True";

        public Order GetOrderById(int orderId)
        {
            Order order = new Order();

            //TO DO
            // write the corresponding code to get the order by id

            return order;
        }
    }
}
