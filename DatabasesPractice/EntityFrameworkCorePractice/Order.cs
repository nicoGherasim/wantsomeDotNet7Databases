using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCorePractice
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int NumberOfPieces { get; set; }

        // for the one to many relationship
        public int ItemId { get; set; }

        public Item Item { get; set; }
    }
}
