using Org.BouncyCastle.Asn1.X509;
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

    public class LevelContent
    {
        int LvlContent_ID { get; set; }
        int LvlContent_LevelID { get; set; }
        int LvlContent_ObjectID { get; set; }
        int LvlContent_OrderNum { get; set; }
        int LvlContent_ModuleID { get; set; }
        string Module_Name { get; set; } = "";
        string Module_Path { get; set; } = "";

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `LevelContent`.`LvlContent_ID` AS `LvlContent_ID`,
                `LevelContent`.`LvlContent_LevelID` AS `LvlContent_LevelID`,
                `LevelContent`.`LvlContent_ObjectID` AS `LvlContent_ObjectID`,
                `LevelContent`.`LvlContent_OrderNum` AS `LvlContent_OrderNum`,
                `LevelContent`.`LvlContent_ModuleID` AS `LvlContent_ModuleID`,
                `Module`.`Module_Name` AS `Module_Name`,
                `Module`.`Module_Path` AS `Module_Path`
            FROM
                (`LevelContent`
                JOIN `Module` ON ((`LevelContent`.`LvlContent_ModuleID` = `Module`.`Module_ID`)))";
            //WHERE xxxx ORDER BY `LevelContent`.`LvlContent_OrderNum`"
        }
    }
}

