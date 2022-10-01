using RTXWebsite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTXWebsite1.IDbContext
{
    public interface IQuizAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
    }
}


