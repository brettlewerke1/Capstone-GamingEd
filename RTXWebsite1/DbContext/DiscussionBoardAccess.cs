﻿
using Dapper;
using MySql.Data.MySqlClient;
using RTXWebsite1.IDbContext;
using RTXWebsite1.Models;
using System.Data;

namespace RTXWebsite1.DbContext
{
    public class DiscussionBoardAccess : IDiscussionBoardAccess
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
    }
}
