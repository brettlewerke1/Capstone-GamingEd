using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
	public class Marketplace
	{
		public int Transaction_ID { get; set; }
		public int Course_ID { get; set; }
		public int Transaction_Cost { get; set; }
		public string? Transaction_Name { get; set; }
		public string? Transaction_Description { get; set; }
    }

	public class BuyAvatars
    {
        // For rest of Avatar functions, see /Models/Avatars.cs
        public int Avatar_ID { get; set; }
        public string Avatar_Image { get; set; }
        public string Avatar_Name { get; set; }
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
}