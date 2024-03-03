using System.ComponentModel.DataAnnotations;

namespace OnlineFood_Project.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Phone { get; set; }

        public List<Order> orders { get; set; }
    }
}
