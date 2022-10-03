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

    public class AvatarMarket
    { 
		public int ACLibrary_ID { get; set; }
		public int ACLibrary_AvatarID { get; set; }
		public int ACLibrary_CourseID { get; set; }

		public static string GetSQL()
        {
            return @"    
            SELECT 
                `AvatarCourseLibrary`.`ACLibrary_ID` AS `ACLibrary_ID`,
                `AvatarCourseLibrary`.`ACLibrary_AvatarID` AS `ACLibrary_AvatarID`,
                `AvatarCourseLibrary`.`ACLibrary_CourseID` AS `ACLibrary_CourseID`,
                `Avatar`.`Avatar_Image` AS `Avatar_Image`,
                `Avatar`.`Avatar_Name` AS `Avatar_Name`
            FROM
                (`AvatarCourseLibrary`
                JOIN `Avatar` ON ((`AvatarCourseLibrary`.`ACLibrary_AvatarID` = `Avatar`.`Avatar_ID`)))";
        }
	}
}