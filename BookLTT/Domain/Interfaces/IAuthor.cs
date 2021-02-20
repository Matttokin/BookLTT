using BookLTT.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BookLTT.Domain.Interfaces
{
    interface IAuthor
    {
        List<Author> GetList();
        SelectList GetListNickName();
        int Add(string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime dateDeath);
        int Update(int id, string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime dateDeath);
        int Delete(int id);
    }
}
