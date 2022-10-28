using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

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
        public string? Account_Username { get; set; }
        public int Player_ID { get; set; }
        public int Player_Coins { get; set; }
        public string? Player_IGN { get; set; }
        public int Course_ID { get; set; }
        public string? Course_Name { get; set; }
        public string? Course_Tag { get; set; }
        public string? Avatar_Image { get; set; }

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
            // Get all : "WHERE Account_ID = @var"
            // Get for one class: "WHERE Player_ID = @var"
        }
    }

    public class Progress
    {
        public int Progress_ID { get; set; }
        public int Progress_PlayerID { get; set; }
        public int Progress_LevelTreeID { get; set; }
        public bool Progress_CompleteFlag { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `Progress`.`Progress_ID` AS `Progress_ID`,
                `Progress`.`Progress_PlayerID` AS `Progress_PlayerID`,
                `Progress`.`Progress_LevelTreeID` AS `Progress_LevelTreeID`,
                `Progress`.`Progress_CompleteFlag` AS `Progress_CompleteFlag`
            FROM
                `Progress`";
        }
    }

    public class ProgressUnlocks
    {
        public int PU_ID { get; set; }
        public int PU_ProgressID { get; set; }
        public int LvlUnlockID { get; set; }
        public int PU_NumVal { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `ProgressUnlocks`.`PU_ID` AS `PU_ID`,
                `ProgressUnlocks`.`PU_ProgressID` AS `PU_ProgressID`,
                `ProgressUnlocks`.`PU_LvlUnlockID` AS `PU_LvlUnlockID`,
                `ProgressUnlocks`.`PU_NumVal` AS `PU_NumVal`
            FROM
                `ProgressUnlocks`";
        }
    }
}
