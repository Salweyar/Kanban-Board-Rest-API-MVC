using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ListData : IListData
    {
        private readonly ISqlDataAccess _db;

        public ListData(ISqlDataAccess db)
        {
            _db = db;
        }

        public IEnumerable<Lists> GetAllList() =>
           _db.LoadData<Lists, dynamic>(sp: "dbo.spList_GetAll", new { });

        public Lists GetList(int id)
        {
            var result = _db.LoadData<Lists, dynamic>(
                sp: "dbo.spList_Get",
                new { Id = id });

            return result.FirstOrDefault();
        }

        public void AddList(Lists list) =>
           _db.SaveData(sp: "dbo.spList_Add",
               new { list.Title, list.Description, list.BoardId });

        public void UpdateList(Lists list) =>
           _db.SaveData(sp: "dbo.spList_Edit", list);

        public void DeleteList(int id) =>
            _db.SaveData(sp: "dbo.spList_Delete",
                new { Id = id });

    }
}
