using RTXWebsite1.Models;


namespace RTXWebsite1.IDbContext
{
    public interface IDiscussionBoardAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);
        Task<List<T>> DeleteData<T, U>(string sql, U parameters, string connectionString);

    }
}
