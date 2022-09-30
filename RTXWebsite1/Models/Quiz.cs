using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Quiz
    {

        
        public int Quiz_ID { get; set; }
        public int Quiz_Number { get; set; }



        public int Quiz_Question_Number { get; set; }
        public string Quiz_Question { get; set; } = "";
        public string Question_Type { get; set; }


        
        // answers
        public string Quiz_Answer { get; set; } = "";
        public string Quiz_Answers { get; set; } = "";
        public string Quiz_Answer_A { get; set; }
        public string Quiz_Answer_B { get; set; }
        public string Quiz_Answer_C { get; set; }
        public string Quiz_Answer_D { get; set; }
        public string Quiz_Answer_E { get; set; }
        public string Quiz_Answer_F { get; set; }





        // entered answers
        public string Entered_Answer_A { get; set; } = "";
        public string Entered_Answer_B { get; set; } = "";
        public string Entered_Answer_C { get; set; } = "";
        public string Entered_Answer_D { get; set; } = "";
        public string Entered_Answer_E { get; set; } = "";
        public string Entered_Answer_F { get; set; } = "";





        // correct answers
        public string Quiz_Correct_Answer { get; set; } = "";
        public string Quiz_Correct_Answer_A { get; set; } = "";
        public string Quiz_Correct_Answer_B { get; set; } = "";





        // Quiz results
        public double numCorrect { get; set; }
        public int numberOfQuestions { get; set; }
        public string Account_Role { get; set; }




        // matching options
        public string Matching_Option_A { get; set; }
        public string Matching_Option_B { get; set; }
        public string Matching_Option_C { get; set; }
        public string Matching_Option_D { get; set; }
        public string Matching_Option_E { get; set; }
        public string Matching_Option_F { get; set; }


        // matching correct options
        public string Matching_Correct_Option_A { get; set; }
        public string Matching_Correct_Option_B { get; set; }
        public string Matching_Correct_Option_C { get; set; }
        public string Matching_Correct_Option_D { get; set; }
        public string Matching_Correct_Option_E { get; set; }
        public string Matching_Correct_Option_F { get; set; }


        // boolean to decide whether to show answers or not
        public string Show_Answer_Bool { get; set; }
        

    }

}