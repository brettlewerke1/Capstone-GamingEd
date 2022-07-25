using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class DiscussionBoard
    {
       public int Discussion_ID { get; set; }

        public string Discussion_Title { get; set;}

        public string Discussion_Desc { get; set; }

        public int Discussion_CourseID { get; set; }

        public string Discussion_Date { get; set; }
    }
}
