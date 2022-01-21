using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _confiuretion;

        public SqlDataAccess(IConfiguration confiuretion)
        {
            _confiuretion = confiuretion;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(
            string sp,
            U parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_confiuretion.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(sp, parameters,
                commandType: CommandType.StoredProcedure);

        }

        public async Task SaveData<T>(
            string sp,
            T parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_confiuretion.GetConnectionString(connectionId));

            await connection.ExecuteAsync(sp, parameters,
                commandType: CommandType.StoredProcedure);

        }

    }
}
