using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
    public class Quiz
    {
        
        public int Quiz_ID { get; set; }
        public int Quiz_Number { get; set; }

        public int Quiz_Question_Number { get; set; }
        
        public string Quiz_Question { get; set; } = "";

        public string Quiz_Answer_A { get; set; } = "";
        
        public string Quiz_Correct_Answer { get; set; } = "";

    }

}