using System.Reflection.Metadata.Ecma335;

namespace RTXWebsite1.Models
{
    public class AssessHead
    {
        public int AssessHead_ID { get; set; }
        public string? AssessHead_Title { get; set; }
        public string? AssessHead_StartDate { get; set; } // MM/DD/YYYY HH:mm:ss
        public string? AssessHead_EndDate { get; set; }
        public bool AssessHead_DisplayAnswers { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `AssessHead`.`AssessHead_ID` AS `AssessHead_ID`,
                `AssessHead`.`AssessHead_Title` AS `AssessHead_Title`,
                `AssessHead`.`AssessHead_StartDate` AS `AssessHead_StartDate`,
                `AssessHead`.`AssessHead_EndDate` AS `AssessHead_EndDate`,
                `AssessHead`.`AssessHead_DisplayAnswers` AS `AssessHead_DisplayAnswers`
            FROM
                `AssessHead`";
        }
    }

    public class Assessment
    {
        // primary key of from assessment table
        public int Assessment_ID { get; set; }

        // type of question being asked
        public string? Assessment_QuestionType { get; set; }

        // actual question being asked
        public string Assessment_Question { get; set; } = "";

        // the entered answer by the user for non-matching questions
        public string Assessment_Answers { get; set; } = "";

        // boolean to decide whether to show answers or not (tinyInt) (0=true, 1=false)
        public bool Assessment_DisplayAnswers { get; set; }

        // points per question
        public int Assessment_PointsPerQuestion { get; set; }

        // number of points earned on assessment
        public int pointsEarned { get; set; }

        // number of total points in assessment
        public int totalPoints { get; set; }

        public string[]? selectedAnswers { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `Assessment`.`Assessment_ID` AS `Assessment_ID`,
                `Assessment`.`Assessment_QuestionType` AS `Assessment_QuestionType`,
                `Assessment`.`Assessment_Question` AS `Assessment_Question`,
                `Assessment`.`Assessment_DisplayAnswers` AS `Assessment_DisplayAnswers`,
                `Assessment`.`Assessment_AssessHeadID` AS `Assessment_AssessHeadID`,
                `Assessment`.`Assessment_PointsPerQuestion` AS `Assessment_PointsPerQuestion`
            FROM
                `Assessment`";
        }
    }

    public class AssessmentAnswers
    {
        // primary key for assessment_answers_table
        public int AssessmentAnswer_ID { get; set; }

        // different options for each question
        public string? AssessmentAnswer_Answers { get; set; }

        // foreign key
        public int AssessmentAnswer_AssessmentID { get; set; }

        // matching answers for matching questions only
        public string? AssessmentAnswer_MatchingAnswer { get; set; }

        // the correct answers to the question
        public string? AssessmentAnswer_CorrectAnswers { get; set; }

        public string? AssessmentAnswer_Selected_Answers { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `AssessmentAnswer`.`AssessmentAnswer_ID` AS `AssessmentAnswer_ID`,
                `AssessmentAnswer`.`AssessmentAnswer_Answers` AS `AssessmentAnswer_Answers`,
                `AssessmentAnswer`.`AssessmentAnswer_AssessmentID` AS `AssessmentAnswer_AssessmentID`,
                `AssessmentAnswer`.`AssessmentAnswer_MatchingAnswer` AS `AssessmentAnswer_MatchingAnswer`,
                `AssessmentAnswer`.`AssessmentAnswer_CorrectAnswers` AS `AssessmentAnswer_CorrectAnswers`
            FROM
                `AssessmentAnswer`";
        }
    }
}