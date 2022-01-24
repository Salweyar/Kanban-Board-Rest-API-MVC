using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Data
{
    public interface ICardData
    {
        void AddCard(Cards card);
        void DeleteCard(int id);
        IEnumerable<Cards> GetAllCard();
        Cards GetCard(int id);
        void UpdateCard(Cards card);
    }
}