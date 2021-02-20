using BookLTT.DataBase;
using BookLTT.DataBase.Models;
using BookLTT.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLTT.Domain
{
    public class AuthorActions : IAuthor
    {
        private ContextDB context;
        public AuthorActions()
        {
            context = new ContextDB();
        }
        public int Add(string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime dateDeath)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetList()
        {
            List<Author> listAuthor = context.Authors.ToList();

            return listAuthor;
        }
        public SelectList GetListNickName()
        {
            SelectList sl = new SelectList(GetList(), "Id", "NickName");

            return sl;
        }

        public int Update(int id, string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime dateDeath)
        {
            throw new NotImplementedException();
        }
    }
}