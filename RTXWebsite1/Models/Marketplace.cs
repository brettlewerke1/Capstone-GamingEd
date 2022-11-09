using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
	public class Marketplace
	{
		public int Transaction_ID { get; set; }
		public int Course_ID { get; set; }
		public bool Transaction_Avatars { get; set; }
        public bool Transaction_Redo { get; set; }
		public bool Transaction_ExemptMedal { get; set; }
		public bool Transaction_ExemptMedalID { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `Transaction`.`Transaction_ID` AS `Transaction_ID`,
                `Transaction`.`Transaction_CourseID` AS `Transaction_CourseID`,
                `Transaction`.`Transaction_Avatars` AS `Transaction_Avatars`,
                `Transaction`.`Transaction_Redo` AS `Transaction_Redo`,
                `Transaction`.`Transaction_ExemptMedal` AS `Transaction_ExemptMedal`,
                `Transaction`.`Transaction_ExemptMedalID` AS `Transaction_ExemptMedalID`
            FROM
                `Transaction`";
        }
    }

	public class BuyAvatars
    {
        // For rest of Avatar functions, see /Models/Avatars.cs
        public int Avatar_ID { get; set; }
        public string? Avatar_Image { get; set; }
        public string? Avatar_Name { get; set; }
        public int Avatar_Cost { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `Avatar`.`Avatar_ID` AS `Avatar_ID`,
                `Avatar`.`Avatar_Image` AS `Avatar_Image`,
                `Avatar`.`Avatar_Name` AS `Avatar_Name`,
                `AvatarCourseLibrary`.`ACLibrary_Cost` AS `Avatar_Cost`
            FROM
            (`Avatar`
            JOIN `AvatarCourseLibrary` ON ((`Avatar`.`Avatar_ID` = `AvatarCourseLibrary`.`ACLibrary_AvatarID`)))";
            // WHERE ACLibrary_CourseID = @variable 
        }
    }

    public class PlayerFullProgress
    {
        public int PU_ID { get; set; }
        public int PU_ProgressID { get; set; }
        public int PU_NumVal { get; set; }      // Current Number obtained
        public int PU_MaxVal { get; set; }      // Current Maximum Lives
        public string? LvlUnlock_Type { get; set; }
        public int LvlContent_ObjectID { get; set; }
        public int LvlContent_OrderNum { get; set; }
        public string? LvlContent_Name { get; set; }
        public bool LvlContent_Unlock { get; set; }
        public string? Module_Name { get; set; }
        public string? Module_Path { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `ProgressUnlocks`.`PU_ID` AS `PU_ID`,
                `ProgressUnlocks`.`PU_ProgressID` AS `PU_ProgressID`,
                `ProgressUnlocks`.`PU_NumVal` AS `PU_NumVal`,
                `ProgressUnlocks`.`PU_MaxVal` AS `PU_MaxVal`,
                `LevelUnlock`.`LvlUnlock_Type` AS `LvlUnlock_Type`,
                `LevelContent`.`LvlContent_ID` AS `LvlContent_ID`,
                `LevelContent`.`LvlContent_LevelID` AS `LvlContent_LevelID`,
                `LevelContent`.`LvlContent_ObjectID` AS `LvlContent_ObjectID`,
                `LevelContent`.`LvlContent_OrderNum` AS `LvlContent_OrderNum`,
                `LevelContent`.`LvlContent_Name` AS `LvlContent_Name`,
                `LevelContent`.`LvlContent_Unlock` AS `LvlContent_Unlock`,
                `Module`.`Module_Name` AS `Module_Name`,
                `Module`.`Module_Path` AS `Module_Path`,
                `Grades`.`Grades_ID` AS `Grades_ID`,
                `Grades`.`Grades_Score` AS `Grades_Score`,
                `Grades`.`Grades_Total` AS `Grades_Total`,
                `Grades`.`Grades_PlayerID` AS `Grades_PlayerID`
            FROM
                ((((`ProgressUnlocks`
                JOIN `LevelUnlock` ON ((`ProgressUnlocks`.`PU_LvlUnlockID` = `LevelUnlock`.`LvlUnlock_ID`)))
                JOIN `LevelContent` ON ((`LevelUnlock`.`LvlUnlock_LvlContentID` = `LevelContent`.`LvlContent_ID`)))
                JOIN `Module` ON ((`LevelContent`.`LvlContent_ModuleID` = `Module`.`Module_ID`)))
                JOIN `Grades` ON (((`LevelContent`.`LvlContent_ObjectID` = `Grades`.`Grades_ObjectID`)
                    AND (`LevelContent`.`LvlContent_ModuleID` = `Grades`.`Grades_ModuleID`))))";
        }

        public static string SortSQL()
        {
            return "ORDER BY `LevelContent`.`LvlContent_LevelID` , `LevelContent`.`LvlContent_OrderNum`";
        }
    }
}