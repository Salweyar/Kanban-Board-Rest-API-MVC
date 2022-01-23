using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Data
{
    public interface IBoardData
    {
        void AddBoard(Boards board);
        void DeleteBoard(int id);
        IEnumerable<Boards> GetAllBoards();
        Boards GetBaord(int id);
        void UpdateBoard(Boards board);
    }
}