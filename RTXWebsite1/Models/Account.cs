using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public string CurrentClass { get; set; }
        public int Coins { get; set; }

        public string Role { get; set; }
    }
}
