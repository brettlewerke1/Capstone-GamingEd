
namespace RTXWebsite1.Models
{ 
    public class Course
    {
        // Metadata of the course itself
        public int Course_ID { get; set; }
        public string? Course_Name { get; set; }
        public string? Course_Tag { get; set; }
        public int Course_LevelID { get; set; }
        public bool Course_MarketFlag { get; set; }
        public string? Course_ProfEmail { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `Course`.`Course_ID` AS `Course_ID`,
                `Course`.`Course_Name` AS `Course_Name`,
                `Course`.`Course_Tag` AS `Course_Tag`,
                `Course`.`Course_LevelID` AS `Course_LevelID`,
                `Course`.`Course_MarketFlag` AS `Course_MarketFlag`,
                `Course`.`Course_ProfEmail` AS `Course_ProfEmail`
            FROM
                `Course`";
        }
    }

    public class Level
    {
        // Data for the information needed in the courses
        public int Level_ID { get; set; }
        public string? Level_Name { get; set; }
        public string? Level_Desc { get; set; }
        public int LevelTree_ID { get; set; } = 0;

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
                `Level`.`Level_Desc` AS `Level_Desc`,
                `LevelTree`.`LevelTree_ID` AS `LevelTree_ID`
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
        public int LvlContent_ModuleID { get; set; }
        public string? LvlContent_Name { get; set; }
        public int Module_ID { get; set; }
        public string Module_Name { get; set; } = "";
        public string Module_Path { get; set; } = "";
        public bool LvlContent_Unlock { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `LevelContent`.`LvlContent_ID` AS `LvlContent_ID`,
                `LevelContent`.`LvlContent_LevelID` AS `LvlContent_LevelID`,
                `LevelContent`.`LvlContent_ObjectID` AS `LvlContent_ObjectID`,
                `LevelContent`.`LvlContent_ModuleID` AS `LvlContent_ModuleID`,
                `LevelContent`.`LvlContent_Name` AS `LvlContent_Name`,
                `Module`.`Module_ID` AS `Module_ID`,
                `Module`.`Module_Name` AS `Module_Name`,
                `Module`.`Module_Path` AS `Module_Path`,
                `LevelContent`.`LvlContent_Unlock` AS `LvlContent_Unlock`
            FROM
                (`LevelContent`
                JOIN `Module` ON ((`LevelContent`.`LvlContent_ModuleID` = `Module`.`Module_ID`)))";
            //WHERE xxxx ORDER BY `LevelContent`.`LvlContent_OrderNum`"
        }
    }

    public class LevelUnlock
    {
        public int LvlUnlock_ID { get; set; }
        public int LevelTreeID { get; set; }
        public string? LvlUnlock_Type { get; set; }
        public int LvlUnlock_NumGoal { get; set; }
        public int LvlUnlock_LvlContentID { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `LevelUnlock`.`LvlUnlock_ID` AS `LvlUnlock_ID`,
                `LevelUnlock`.`LvlUnlock_LevelTreeID` AS `LvlUnlock_LevelTreeID`,
                `LevelUnlock`.`LvlUnlock_Type` AS `LvlUnlock_Type`,
                `LevelUnlock`.`LvlUnlock_NumGoal` AS `LvlUnlock_NumGoal`,
                `LevelUnlock`.`LvlUnlock_LvlContentID` AS `LvlUnlock_LvlContentID`
            FROM
                `LevelUnlock`";
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

