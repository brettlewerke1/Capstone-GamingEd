
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
        public int LvlContent_ID { get; set; }
        public int LvlContent_LevelID { get; set; }
        public int LvlContent_ObjectID { get; set; }
        public int LvlContent_OrderNum { get; set; }
        public int LvlContent_ModuleID { get; set; }
        public string? LvlContent_Name { get; set; }
        public string Module_Name { get; set; } = "";
        public string Module_Path { get; set; } = "";

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `LevelContent`.`LvlContent_ID` AS `LvlContent_ID`,
                `LevelContent`.`LvlContent_LevelID` AS `LvlContent_LevelID`,
                `LevelContent`.`LvlContent_ObjectID` AS `LvlContent_ObjectID`,
                `LevelContent`.`LvlContent_OrderNum` AS `LvlContent_OrderNum`,
                `LevelContent`.`LvlContent_ModuleID` AS `LvlContent_ModuleID`,
                `LevelContent`.`LvlContent_Name` AS `LvlContent_Name`,
                `Module`.`Module_Name` AS `Module_Name`,
                `Module`.`Module_Path` AS `Module_Path`
            FROM
                (`LevelContent`
                JOIN `Module` ON ((`LevelContent`.`LvlContent_ModuleID` = `Module`.`Module_ID`)))";
            //WHERE xxxx ORDER BY `LevelContent`.`LvlContent_OrderNum`"
        }
    }

    public class TextBlock
    {
        public int Text_ID { get; set; }
        public string? Text_Title { get; set; }
        public string? Text_Content { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `Text`.`Text_ID` AS `Text_ID`,
                `Text`.`Text_Title` AS `Text_Title`,
                `Text`.`Text_Content` AS `Text_Content`
            FROM
                `Text`";
        }
    }
}

