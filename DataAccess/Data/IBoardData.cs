using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IBoardData
    {
        Task AddBoard(Boards board);
        Task DeleteBoard(int id);
        Task<Boards> GetBaord(int id);
        Task<IEnumerable<Boards>> GetAllBoards();
        Task UpdateBoard(Boards board);
    }
}