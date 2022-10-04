using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class DiscussionBoard
    {
        public int Discussion_ID { get; set; }
        public string? Discussion_Title { get; set;}
        public string? Discussion_Desc { get; set; }
        public int Discussion_CourseID { get; set; }
        public string? Discussion_Date { get; set; } // YYYY-MM-DD
        public int Discussion_PlayerID { get; set; }
        public string? Player_IGN { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `DiscussionHead`.`Discussion_ID` AS `Discussion_ID`,
                `DiscussionHead`.`Discussion_Title` AS `Discussion_Title`,
                `DiscussionHead`.`Discussion_Desc` AS `Discussion_Desc`,
                `DiscussionHead`.`Discussion_CourseID` AS `Discussion_CourseID`,
                `DiscussionHead`.`Discussion_Date` AS `Discussion_Date`,
                `DiscussionHead`.`Discussion_PlayerID` AS `Discussion_PlayerID`,
                `Player`.`Player_IGN` AS `Player_IGN`
            FROM
                (`DiscussionHead`
                JOIN `Player` ON ((`DiscussionHead`.`Discussion_PlayerID` = `Player`.`Player_ID`))) ";
        }
    }

    public class DiscussionPost
    { 
        public int Post_ID { get; set; }
        public string? Post_Content { get; set; }
        public string? Post_Time { get; set; } // YYYY-MM-DD
        public int Post_PlayerID { get; set; }
        public int Post_HeadPostID { get; set; }
        public string Player_IGN { get; set; }

        public static string GetSQL()
        {
            return @"
            SELECT 
                `DiscussionPost`.`Post_ID` AS `Post_ID`,
                `DiscussionPost`.`Post_Content` AS `Post_Content`,
                `DiscussionPost`.`Post_Time` AS `Post_Time`,
                `DiscussionPost`.`Post_PlayerID` AS `Post_PlayerID`,
                `DiscussionPost`.`Post_HeadPostID` AS `Post_HeadPostID`,
                `Player`.`Player_IGN` AS `Player_IGN`
            FROM
                (`DiscussionHead`
                JOIN `DiscussionPost` ON ((`DiscussionHead`.`Discussion_ID` = `DiscussionPost`.`Post_HeadPostID`))
                JOIN `Player` ON ((`DiscussionPost`.`Post_PlayerID` = `Player`.`Player_ID`)))";
        }
    }

}
