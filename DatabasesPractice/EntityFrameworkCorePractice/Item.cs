using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCorePractice
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Column("Name")]
        [MaxLength(20)]
        public string Name { get; set; }

        //[Required]
        public int Price { get; set; }

        // for the one to many relationship 
        public List<Order> Orders { get; set; }
    }
}
