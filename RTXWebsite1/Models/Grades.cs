namespace RTXWebsite1.Models
{
    public class Grades
    {
        public int Grades_ModuleID { get; set; }

        // score on specific assignment
        public int? Grades_Score { get; set; }

        // what score was out of on a specific assignment
        public int Grades_Total { get; set; }

        public int Grades_ObjectID { get; set; }





        public double Summed_Score_Total { get; set; }

        public double Summed_Grades_Total { get; set; }


        public double Calculated_Grade { get; set; }

        public char LetterGrade { get; set; }









        // retrieving all the variables in the "Grades" table
        public static string GetSQL()
        {
            return @"    
            SELECT 
                `Grades`.`Grades_ID` AS `Grades_ID`,
                `Grades`.`Grades_Score` AS `Grades_Score`,
                `Grades`.`Grades_Total` AS `Grades_Total`,
                `Grades`.`Grades_PlayerID` AS `Grades_PlayerID`,
                `Grades`.`Grades_ObjectID` AS `Grades_ObjectID`,
                `Grades`.`Grades_ModuleID` AS `Grades_ModuleID`
            FROM
                `Grades`";
        }







    }

}