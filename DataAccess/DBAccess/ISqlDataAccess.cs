
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DBAccess
{
    public interface ISqlDataAccess
    {
        IEnumerable<T> LoadData<T, U>(string sp, U parameters, string connectionId = "Default");
        void SaveData<T>(string sp, T parameters, string connectionId = "Default");
    }
}