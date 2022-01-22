using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace KanbanApi.Controllers
{
    [Route("api/boards")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly IBoardData _board;

        public BoardsController(IBoardData board)
        {
            _board = board;
        }

        [HttpGet]
        public Task<IEnumerable<Boards>> Get()
        {
            var boards = _board.GetAllBoards();
            return boards;
        }

        [HttpGet("{id}")]
        public Task<Boards> GetBoard(int id)
        {
            var board = _board.GetBaord(id);
            return board;
        }

        [HttpPost("{title}")]
        public Task AddNewBoard(string title, string description)
        {
            var add = _board.AddBoard(new Boards { Title = title, Description = description });
            return add;
        }

        [HttpPut("{id}")]
        public Task UpdateBoard(int id, string title, string description)
        {
            var edit = _board.UpdateBoard(new Boards { Id = id, Title = title, Description = description });
            return edit;
        }

        [HttpDelete("{id}")]
        public Task DeleteBoard(int id)
        {
            var delete = _board.DeleteBoard(id);
            return delete;
        }

    }
}
