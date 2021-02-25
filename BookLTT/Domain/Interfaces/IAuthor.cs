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
        Author GetById(int id);
        string Add(string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime dateDeath);
        string Update(int id, string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime? dateDeath);
        string Delete(int id);
    }
}
