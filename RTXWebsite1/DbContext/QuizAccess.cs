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
            string sqlString = "select * from Quiz where Quiz_Number = 1 AND Quiz_Question_Number = 1";

            List<Quiz> registeredQuiz = await LoadData<Quiz, dynamic>(sqlString, new { }, configuration.GetConnectionString("RTX"));

            if (registeredQuiz != null)
            {
                foreach (Quiz item in registeredQuiz)
                {
                    if (item.Quiz_Correct_Answer == quiz.Quiz_Answer_A)
                    {
                        // you got it right
                        return 0;
                    }
                    else
                    {
                        // you got it wrong
                        return 1;
                    }
                }
            }
            // return false is the username and password are not there
            return 1;

        }
    }
}

