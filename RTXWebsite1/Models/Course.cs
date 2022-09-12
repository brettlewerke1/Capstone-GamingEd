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

        public int getHeadID()
        {
            return (int)Course_LevelHeadID;
        }
    }
    public class Level
    {
        // Data for the information needed in the courses
        public int Level_ID;
        public string? Level_Name;
        public string? Level_Desc;
    }
}
