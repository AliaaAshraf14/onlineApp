using System.ComponentModel.DataAnnotations;

namespace OnlineFood_Project.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<OrderDetaile> OrderDetailes { get; set; }



    }
}
