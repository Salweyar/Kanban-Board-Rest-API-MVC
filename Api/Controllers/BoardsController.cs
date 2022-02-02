using DataAccess.Data;
using DataAccess.Models;
using KanbanApi.Attributes;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace KanbanApi.Controllers
{

    [ApiKey]
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
        public IEnumerable<Boards> Get()
        {
            var boards = _board.GetAllBoards();
            return boards;
        }

        [HttpGet("{id}")]
        public ActionResult<Boards> GetBoard(int id)
        {
            var board = _board.GetBaord(id);

            return board;
        }

        /// <returns>Add Boards</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost("{title}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void AddNewBoard(string title, string description)
        {
            _board.AddBoard(new Boards { Title = title, Description = description });
        }

        [HttpPut("{id}")]
        public void UpdateBoard(int id, string title, string description)
        {
            _board.UpdateBoard(new Boards { Id = id, Title = title, Description = description });
        }

        /// <summary>
        /// Deletes a specific Board.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteBoard(int id)
        {
            _board.DeleteBoard(id);
        }

    }
}
