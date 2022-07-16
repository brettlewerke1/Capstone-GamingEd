using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Account
    {
        public int Account_ID { get; set; }

        public string Account_Username { get; set; }

        public string Account_Password { get; set; }
        
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        
        public string CurrentClass { get; set; }
        public int Coins { get; set; }

        public string ClassOne { get; set; }

        public string ClassTwo { get; set; }

        public string Role { get; set; }
    }

    public class PlayerInformation
    {
        public int Account_ID { get; set; }
        public string Account_Username { get; set; }
        public string Account_Password { get; set; }
        public int Player_Coins { get; set; }
        public string Player_IGN { get; set; }
        public int Course_ID { get; set; }
        public string Course_Name { get; set; } 
        public string Course_Tag { get; set; }
    }
}
