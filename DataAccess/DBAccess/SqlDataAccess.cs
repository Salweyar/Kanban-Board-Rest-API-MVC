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

        public IEnumerable<T> LoadData<T, U>(
            string sp,
            U parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_confiuretion.GetConnectionString(connectionId));

            return connection.Query<T>(sp, parameters,
                commandType: CommandType.StoredProcedure);

        }

        public void SaveData<T>(
            string sp,
            T parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_confiuretion.GetConnectionString(connectionId));

             connection.Execute(sp, parameters,
                commandType: CommandType.StoredProcedure);

        }

    }
}
