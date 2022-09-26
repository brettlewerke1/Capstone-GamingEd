using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Account
    {
        public int Account_ID { get; set; }
        [Required]
        public string Account_Username { get; set; } = "";
        [Required]
        public string Account_Password { get; set; } = "";
        public string Account_Role { get; set; } = "student";

    }
    public class PlayerInformation
    {
        public int Account_ID { get; set; }
        public string Account_Username { get; set; }
        public int Player_ID { get; set; }
        public int Player_Coins { get; set; }
        public string Player_IGN { get; set; }
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Tag { get; set; }
    }
}
