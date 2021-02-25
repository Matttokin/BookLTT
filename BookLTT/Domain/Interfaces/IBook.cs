using BookLTT.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLTT.Domain.Interfaces
{
    interface IBook
    {
        List<Book> GetList();
        string Add(string title, int authorId, double price, DateTime datePrint, string publishing, int edition);
        Book GetById(int id);
        string Update(int id, string title, int authorId, double price, DateTime datePrint, string publishing, int edition);
        string Delete(int id);
    }
}
