using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Avatar
    {
        public int Avatar_ID { get; set; }
        public string Avatar_Image { get; set; }
        public string Avatar_Name { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `Avatar`.`Avatar_ID` AS `Avatar_ID`,
                `Avatar`.`Avatar_Image` AS `Avatar_Image`,
                `Avatar`.`Avatar_Name` AS `Avatar_Name`
            FROM
                `Avatar`";
        }

        public static string GetSQL_ACLibrary()
        {
            // AvatarCourseLibrary Bridge Table
            return @"
            SELECT 
                `Avatar`.`Avatar_ID` AS `Avatar_ID`,
                `Avatar`.`Avatar_Image` AS `Avatar_Image`,
                `Avatar`.`Avatar_Name` AS `Avatar_Name`
            FROM
            (`Avatar`
            JOIN `AvatarCourseLibrary` ON ((`Avatar`.`Avatar_ID` = `AvatarCourseLibrary`.`ACLibrary_AvatarID`)))";
            // WHERE ACLibrary_CourseID = @variable
        }

        public static string GetSQL_APLibrary()
        {
            // AvatarPlayerLibrary Bridge Table
            return @"    
            SELECT 
                `Avatar`.`Avatar_ID` AS `Avatar_ID`,
                `Avatar`.`Avatar_Image` AS `Avatar_Image`,
                `Avatar`.`Avatar_Name` AS `Avatar_Name`
            FROM
            (`Avatar`
            JOIN `AvatarPlayerLibrary` ON ((`Avatar`.`Avatar_ID` = `AvatarPlayerLibrary`.`APLibrary_AvatarID`)))";
            // WHERE APLibrary_PlayerID = @variable
        }
    }
}