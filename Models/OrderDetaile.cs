using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineFood_Project.Models
{
    public class OrderDetaile
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int order_Id { get; set; }
        [ForeignKey("Menu")]
        public int menu_Id { get; set; }
        public Order order { get; set; }
        public Menu menu { get; set; }
    }
}
