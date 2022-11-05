namespace RTXWebsite1.Models
{
    public class Assignment
    {
        public int Assignment_ID { get; set; }
        public string? Assignment_Title { get; set; }
        public string? Assignment_Desc { get; set; }
        public string? Assignment_StartDate { get; set; }
        public string? Assignment_EndDate { get; set; }
        public int Assignment_TotalScore { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `Assignment`.`Assignment_ID` AS `Assignment_ID`,
                `Assignment`.`Assignment_Title` AS `Assignment_Title`,
                `Assignment`.`Assignment_Desc` AS `Assignment_Desc`,
                `Assignment`.`Assignment_StartDate` AS `Assignment_StartDate`,
                `Assignment`.`Assignment_EndDate` AS `Assignment_EndDate`,
                `Assignment`.`Assignment_TotalScore` AS `Assignment_TotalScore`
            FROM
                `Assignment`";
        }
    }

    public class AssignmentSubmissions
    {
        public int AsssignmentS_ID { get; set; }
        public int AssignmentS_AssignmentID { get; set; }
        public int AssignmentS_PlayerID { get; set; }
        public string? AssignmentS_Comment { get; set; }
        public string? AssignmentS_StringUpload { get; set; }
        public string? AssignmentS_FileType { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `AssignmentSubmissions`.`AssignmentS_ID` AS `AssignmentS_ID`,
                `AssignmentSubmissions`.`AssignmentS_AssignmentID` AS `AssignmentS_AssignmentID`,
                `AssignmentSubmissions`.`AssignmentS_PlayerID` AS `AssignmentS_PlayerID`,
                `AssignmentSubmissions`.`AssignmentS_Comment` AS `AssignmentS_Comment`,
                `AssignmentSubmissions`.`AssignmentS_StringUpload` AS `AssignmentS_StringUpload`,
                `AssignmentSubmissions`.`AssignmentS_FileType` AS `AssignmentS_FileType`
            FROM
                `AssignmentSubmissions`";
            // WHERE AssignmentS_AssignmentID == var AND AssignmentS_PlayerID = var
        }
    }

}
