using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class DiscussionBoard
    {
        public int Discussion_ID { get; set; }
        public string Discussion_Title { get; set;}
        public string Discussion_Desc { get; set; }
        public int Discussion_CourseID { get; set; }
        public DateTime Discussion_Date { get; set; }
        public int Discussion_AccountID { get; set; }

    }

    public class DiscussionPost
    { 
        public int Post_ID { get; set; }
        public string? Post_Title { get; set; }
        public string? Post_Content { get; set; }
        public DateTime Post_Time { get; set; } // YYYY-MM-DD
        public int Post_AccountID { get; set; }
        public int Post_HeadPostID { get; set; }
    }

}
