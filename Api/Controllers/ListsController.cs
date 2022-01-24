using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KanbanApi.Controllers
{
    [Route("api/lists")]
    [ApiController]
    public class ListsController : ControllerBase
    {
        private readonly IListData _lists;

        public ListsController(IListData lists)
        {
            _lists = lists;
        }

        [HttpGet]
        public IEnumerable<Lists> Get()
        {
            var lists = _lists.GetAllList();
            return lists;
        }

        [HttpGet("{id}")]
        public ActionResult<Lists> GetList(int id)
        {
            var list = _lists.GetList(id);
            return list;
        }

        [HttpPost("{boardId}")]       
        public void AddNewList(int boardId, string title, string description)
        {
            _lists.AddList(new Lists { BoardId = boardId, Title = title, Description = description });
        }

        [HttpPut("{id}/{boardId}")]
        public void UpdateList(int id, int boardId, string title, string description)
        {
            _lists.UpdateList(new Lists { Id = id, BoardId = boardId, Title = title, Description = description });
        }

        [HttpDelete("{id}")]
        public void DeleteList(int id)
        {
            _lists.DeleteList(id);
        }

    }
}
