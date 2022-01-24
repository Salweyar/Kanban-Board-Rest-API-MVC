using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace KanbanApi.Controllers
{
    [Route("api/cards")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardData _cards;

        public CardsController(ICardData cards)
        {
            _cards = cards;
        }

        [HttpGet]
        public IEnumerable<Cards> Get()
        {
            var cards = _cards.GetAllCard();
            return cards;
        }

        [HttpGet("{id}")]
        public ActionResult<Cards> GetCard(int id)
        {
            var cards = _cards.GetCard(id);
            return cards;
        }

        [HttpPost("{cardId}")]
        public void AddNewCard(int cardId, string title, string description, string status, DateTime? start, DateTime? end, string assignee, string report, string point)
        {
            _cards.AddCard(new Cards { ListId = cardId, Title = title, Description = description, Status = status, StartDate = start, EndDate = end, AssigneTo = assignee, ReportTo = report, StoryPoints = point });
        }

        [HttpPut("{id}/{listId}")]
        public void UpdateCard(int id, int listId, string title, string description, string status, DateTime? start, DateTime? end, string assignee, string report, string point)
        {
            _cards.UpdateCard(new Cards { Id = id, ListId = listId, Title = title, Description = description, Status = status, StartDate = start, EndDate = end, AssigneTo = assignee, ReportTo = report, StoryPoints = point });
        }

        [HttpDelete("{id}")]
        public void DeleteList(int id)
        {
            _cards.DeleteCard(id);
        }

    }
}
