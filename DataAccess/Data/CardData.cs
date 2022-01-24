using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class CardData : ICardData
    {
        private readonly ISqlDataAccess _db;

        public CardData(ISqlDataAccess db)
        {
            _db = db;
        }

        public IEnumerable<Cards> GetAllCard() =>
          _db.LoadData<Cards, dynamic>(sp: "dbo.spCard_GetAll", new { });

        public Cards GetCard(int id)
        {
            var result = _db.LoadData<Cards, dynamic>(
                sp: "dbo.spCard_Get",
                new { Id = id });

            return result.FirstOrDefault();
        }

        public void AddCard(Cards card) =>
          _db.SaveData(sp: "dbo.spCard_Add",
              new { card.Title, card.Description, card.ListId, card.Status, card.StartDate, card.EndDate, card.AssigneTo, card.ReportTo, card.StoryPoints });

        public void UpdateCard(Cards card) =>
           _db.SaveData(sp: "dbo.spCard_Edit", card);

        public void DeleteCard(int id) =>
            _db.SaveData(sp: "dbo.spCard_Delete",
                new { Id = id });

    }
}
