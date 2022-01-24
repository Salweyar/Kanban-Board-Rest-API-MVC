using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Data
{
    public interface IListData
    {
        void AddList(Lists list);
        void DeleteList(int id);
        IEnumerable<Lists> GetAllList();
        Lists GetList(int id);
        void UpdateList(Lists list);
    }
}