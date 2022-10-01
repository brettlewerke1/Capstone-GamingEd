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
    public class AccountAccess : IAccountAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public async Task<int> ValidateAccount(Account account, IConfiguration configuration)
        {
            // call load data and check for account information
            string sqlString = "select * from Account where Account_Username='" + account.Account_Username + "' AND Account_Password='" + account.Account_Password + "' Limit 1;";

            List<Account> registeredAccount = await LoadData<Account, dynamic>(sqlString, new { }, configuration.GetConnectionString("RTX"));

            if (registeredAccount != null)
            {
                foreach (Account item in registeredAccount)
                {
                    if (item.Account_Username == account.Account_Username)
                    {
                        return item.Account_ID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            // return false is the username and password are not there
            return 0;

        }
    }
}
