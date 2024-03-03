using System.ComponentModel.DataAnnotations;

namespace OnlineFood_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Menu Menu { get; set; }
    }
}
