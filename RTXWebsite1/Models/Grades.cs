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





        public double Summed_Score_Total { get; set; }

        public double Summed_Grades_Total { get; set; }


        public double Calculated_Grade { get; set; }

        public char LetterGrade { get; set; }




        // forign key from AssignmentSubmissions table (to tell which assignment number it is)
        public int Grades_AssignmentS_AssignmentID { get; set; }

        
        // foriegn key from Assessment table
        public int Grades_AssessHead_ID { get; set; }
    }

}