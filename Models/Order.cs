using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineFood_Project.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public double Total { get; set; }
        [ForeignKey("Client")]
        public int Client_id { get; set; }
        public Client Client { get; set; }

        public List<OrderDetaile> OrderDetailes { get; set; }

    }
}
