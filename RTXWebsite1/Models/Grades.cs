namespace RTXWebsite1.Models
{
    public class Grades
    {
        public int Grades_ModuleID { get; set; }

        // score on specific assignment
        public int Grades_Score { get; set; }

        // what score was out of on a specific assignment
        public int Grades_Total { get; set; }

        public int Grades_ObjectID { get; set; }
    }

}