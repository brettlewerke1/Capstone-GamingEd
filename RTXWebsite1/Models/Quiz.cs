using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Quiz
    {

        public int Quiz_ID { get; set; }

        public string Quiz_Word_Val { get; set; } = "";
        public int Quiz_Number { get; set; }

        public int Quiz_Question_Number { get; set; }

        public string Quiz_Question { get; set; } = "";

        public string Quiz_Answers { get; set; } = "";

        public string Quiz_Answer { get; set; } = "";

        public string Quiz_Answer_A { get; set; }

        public string Quiz_Answer_B { get; set; }
        public string Quiz_Answer_C { get; set; }
        public string Quiz_Answer_D { get; set; }
        public string Quiz_Answer_E { get; set; }

        public string Quiz_Answer_F { get; set; }
        public string Quiz_Correct_Answer { get; set; } = "";
        public string Quiz_Correct_Answer_A { get; set; } = "";
        public string Quiz_Correct_Answer_B { get; set; } = "";


        // Quiz Results table
        public int QuizResults_ID { get; set; }

        public int QuizResults_AccountID { get; set; }

        public int numCorrect { get; set; }

        public int numberOfQuestions { get; set; }

        public string Account_Role { get; set; }

    }

}