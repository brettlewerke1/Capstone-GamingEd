using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
	public class QuizAnswers
	{
		public int idNewQuiz { get; set; }

		public string Quiz_Answers { get; set; }


		// foreign key
		public int Quiz_ID { get; set; }


		public string Matching_Answer { get; set; }
		public string Selected_Answers {get; set; }

		public string Correct_Answers { get; set; }

	}
}