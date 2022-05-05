using Dapper;
using Microsoft.AspNetCore.Identity;
using MySql.Data.MySqlClient;
using RTXWebsite1.IDbContext;
using RTXWebsite1.Models;
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

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<Boolean> ValidateAccount(Account account, IConfiguration configuration)
        {
;
            // call load data and check for account information
            string username = account.Username;
            string password = account.Password;
            string sqlString = "select * from people where Username='" +username+"' AND Password='" + password+ "';";

            List<Account> registeredAccount = await LoadData<Account, dynamic>(sqlString, new { }, configuration.GetConnectionString("Account"));

            if (registeredAccount != null)
            {
                foreach (Account item in registeredAccount)
                {
                    if (item.Username == username)
                    {


                        //await HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, "Cookies", "name")));

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            // return false is the username and password are not there
            return false;

        }
    }
}
