using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class BoardData : IBoardData
    {
        private readonly ISqlDataAccess _db;

        public BoardData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Boards>> GetAllBoards() =>
            _db.LoadData<Boards, dynamic>(sp: "dbo.spBoard_GetAll", new { });

        public async Task<Boards?> GetBaord(int id)
        {
            var result = await _db.LoadData<Boards, dynamic>(
                sp: "dbo.spBoard_Get",
                new { Id = id });

            return result.FirstOrDefault();
        }

        public Task AddBoard(Boards board) =>
            _db.SaveData(sp: "dbo.spBoard_Add",
                new { board.Title, board.Description });

        public Task UpdateBoard(Boards board) =>
            _db.SaveData(sp: "dbo.spBoard_Edit", board);

        public Task DeleteBoard(int id) =>
            _db.SaveData(sp: "dbo.Board_Delete",
                new { Id = id });

    }
}
