
namespace DataAccess.DBAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string sp, U parameters, string connectionId = "Default");
        Task SaveData<T>(string sp, T parameters, string connectionId = "Default");
    }
}