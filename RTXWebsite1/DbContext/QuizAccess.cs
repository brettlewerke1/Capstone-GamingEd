using Dapper;
using Microsoft.AspNetCore.Identity;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;


using RTXWebsite1.IDbContext;
using RTXWebsite1.Models;


namespace RTXWebsite1.DbContext
{
    public class QuizAccess : IQuizAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public async Task<int> ValidateAnswer(Quiz quiz, IConfiguration configuration)
        {
            // call load data and check for account information
            string sqlString = "select * from Quiz where Quiz_Number = 1";

            // number for amount of questions correct
            int numberOfCorrect = 0;


            List<Quiz> registeredQuiz = await LoadData<Quiz, dynamic>(sqlString, new { }, configuration.GetConnectionString("RTX"));

            if (registeredQuiz != null)
            {
                foreach (Quiz item in registeredQuiz)
                {

                    // if it is question 1
                    if( item.Quiz_Question_Number == 1 )
                    {
                        // if quesion has been answered
                        if (quiz.Quiz_Answer_1 != "")
                        {
                            // check if answer is correct
                            if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_1)
                            {

                                // increment number of correct
                                numberOfCorrect++;

                            }

                        }

                    }

                    // if it is question 2
                    if( item.Quiz_Question_Number == 2 )
                    {
                        // if question 2 has been answered
                        if (quiz.Quiz_Answer_2 != "")
                        {
                            // check if answer is correct
                            if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_2)
                            {

                                // increment number of correct
                                numberOfCorrect++;

                            }

                        }
                    }


                    // if it is question 3
                    if (item.Quiz_Question_Number == 3)
                    {
                        // if quesion has been answered
                        if (quiz.Quiz_Answer_3 != "")
                        {
                            // check if answer is correct
                            if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_3)
                            {

                                // increment number of correct
                                numberOfCorrect++;

                            }

                        }

                    }

                    // if it is question 4
                    if (item.Quiz_Question_Number == 4)
                    {
                        // if quesion has been answered
                        if (quiz.Quiz_Answer_4 != "")
                        {
                            // check if answer is correct
                            if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_4)
                            {

                                // increment number of correct
                                numberOfCorrect++;

                            }

                        }

                    }


                    // if it is question 5
                    if (item.Quiz_Question_Number == 5)
                    {
                        // if quesion has been answered
                        if (quiz.Quiz_Answer_5 != "")
                        {
                            // check if answer is correct
                            if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_5)
                            {
                                // increment number of correct
                                numberOfCorrect++;

                            }

                        }

                    }


                    // if it is question 6
                    if (item.Quiz_Question_Number == 6)
                    {
                        // if quesion has been answered
                        if (quiz.Quiz_Answer_6 != "")
                        {
                            // check if answer is correct
                            if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_6)
                            {
                                // increment number of correct
                                numberOfCorrect++;

                            }

                        }

                    }


                }

                // succesul operation
                return numberOfCorrect;
            }

            // registeredQuiz is null
            return -1;

        }
    }
}

