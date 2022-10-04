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

        public static string GetSQL()
        {
            return @"
            SELECT
                `Account`.`Account_ID` AS `Account_ID`,
                `Account`.`Account_Username` AS `Account_Username`,
                `Account`.`Account_Password` AS `Account_Password`
            FROM
                `Account`";
        }
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
        public string Avatar_Image { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `Account`.`Account_ID` AS `Account_ID`,
                `Account`.`Account_Username` AS `Account_Username`,
                `Player`.`Player_ID` AS `Player_ID`,
                `Player`.`Player_Coins` AS `Player_Coins`,
                `Player`.`Player_IGN` AS `Player_IGN`,
                `Course`.`Course_ID` AS `Course_ID`,
                `Course`.`Course_Name` AS `Course_Name`,
                `Course`.`Course_Tag` AS `Course_Tag`,
                `Avatar`.`Avatar_Image` AS `Avatar_Image`
            FROM
                (((`Account`
                JOIN `Player` ON ((`Account`.`Account_ID` = `Player`.`Player_AccountID`)))
                JOIN `Course` ON ((`Player`.`Player_CourseID` = `Course`.`Course_ID`)))
                JOIN `Avatar` ON ((`Player`.`Player_CurrentAvatarID` = `Avatar`.`Avatar_ID`)))";
        }
    }
}
