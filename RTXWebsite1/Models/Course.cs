using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{ 
    public class Course
    {
        // Metadata of the course itself
        public int Course_ID { get; set; }
        public string? Course_Name;
        public string? Course_Tag;
        public int Course_LevelHeadID;
        public bool Course_MarketFlag;
    }
    public class Level
    {
        // Data for the information needed in the courses
        public int Level_ID;
        public string? Level_Name;
        public string? Level_Desc;

        public static string GetSQL()
        {
            return @"
            SELECT 
                `Level`.`Level_ID` AS `Level_ID`,
                `Level`.`Level_Name` AS `Level_Name`,
                `Level`.`Level_Desc` AS `Level_Desc`
            FROM
                `Level`";
        }

        public static string GetSQLChild()
        {
            return @"
            SELECT 
                `LevelTree`.`LevelTree_NextLevelID` AS `Level_ID`,
                `Level`.`Level_Name` AS `Level_Name`,
                `Level`.`Level_Desc` AS `Level_Desc`
            FROM
                (`LevelTree`
                JOIN `Level` ON ((`LevelTree`.`LevelTree_NextLevelID` = `Level`.`Level_ID`)))";
        }
    }
}

