using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Assessment
    {

        // primary key of from assessment table
        public int Assessment_ID { get; set; }

        // quiz number representing which quiz is being taken
        public int Quiz_Number { get; set; }

        // question number
        public int Assessment_Question_Number { get; set; }

        // type of question being asked
        public string Assessment_Question_Type { get; set; }

        // actual question being asked
        public string Assessment_Question { get; set; } = "";


        // the entered answer by the user for non-matching questions
        public string Assessment_Answers { get; set; } = "";

        // number of points earned on assessment
        public int pointsEarned { get; set; }

        // number of total points in assessment
        public int totalPoints { get; set; }
    
        // boolean to decide whether to show answers or not (tinyInt) (0=true, 1=false)
        public byte Assessment_Display_Answers { get; set; }

        // points per question
        public int Points_Per_Question { get; set; }
        

    }

}