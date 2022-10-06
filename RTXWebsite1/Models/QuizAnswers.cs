using System.ComponentModel.DataAnnotations;

namespace RTXWebsite1.Models
{
	public class QuizAnswers
	{
		// primary key for assessment_answers_table
		public int AssessmentAnswer_ID { get; set; }

		// different options for each question
		public string AssessmentAnswer_Answers { get; set; }


		// foreign key
		public int AssessmentAnswer_Assessment_ID { get; set; }

		// matching answers for matching questions only
		public string AssessmentAnswer_Matching_Answer { get; set; }

		// selected answer by the user
		public string AssessmentAnswer_Selected_Answers {get; set; }

		// the correct answers to the question
		public string AssessmentAnswer_Correct_Answers { get; set; }





	}
}