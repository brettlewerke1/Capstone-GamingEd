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


        // boolean to decide whether to show answers or not (tinyInt) (0=true, 1=false)
        public bool Assessment_DisplayAnswers { get; set; }

        // points per question
        public int Assessment_PointsPerQuestion { get; set; }

        // number of points earned on assessment
        public int pointsEarned { get; set; }

        // number of total points in assessment
        public int totalPoints { get; set; }

        // Selected Answer for Non-Matching Questions
        public string? Assessment_SelectedAnswer { get; set; }

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

        // different drop down options for each question
        public string? AssessmentAnswer_MatchingDropDownOption { get; set; }

        // foreign key
        public int AssessmentAnswer_AssessmentID { get; set; }

        // matching answers for matching questions only
        public string? AssessmentAnswer_MatchingOption { get; set; }

        // the correct answers to the question
        public string? AssessmentAnswer_CorrectAnswers { get; set; }


        public int AssessHeadID { get; set; }


        // Selected Answer for Matching Questions Only
        public string? AssessmentAnswer_EnteredAnswer { get; set; }

        // option for multiple choice answer
        public string? AssessmentAnswer_MultipleChoiceOption { get; set; }

        public static string GetSQL()
        {
            return @"    
            SELECT 
                `AssessmentAnswer`.`AssessmentAnswer_ID` AS `AssessmentAnswer_ID`,
                `AssessmentAnswer`.`AssessmentAnswer_MatchingDropDownOption` AS `AssessmentAnswer_MatchingDropDownOption`,
                `AssessmentAnswer`.`AssessmentAnswer_AssessmentID` AS `AssessmentAnswer_AssessmentID`,
                `AssessmentAnswer`.`AssessmentAnswer_MatchingOption` AS `AssessmentAnswer_MatchingOption`,
                `AssessmentAnswer`.`AssessmentAnswer_CorrectAnswers` AS `AssessmentAnswer_CorrectAnswers`,
                `AssessmentAnswer`.`AssessmentAnswer_AssessHeadID` AS `AssessmentAnswer_AssessHeadID`,
                `AssessmentAnswer`.`AssessmentAnswer_MultipleChoiceOption` AS `AssessmentAnswer_MultipleChoiceOption`
            FROM
                `AssessmentAnswer`";
        }
    }
}