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
        public string Add(string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime dateDeath)
        {
            if (dateDeath != null && dateBirth > dateDeath) return ResponseList.ERR_AUTHOR_BAD_DATE_BOD;
            if (nickName.Length < 3) return ResponseList.ERR_AUTHOR_NICKNAME_SHORT;

            context.Authors.Add(new Author()
            {
                Surname = surname,
                Name = name,
                Patronymic = patronymic,
                NickName = nickName,
                DateBirth = dateBirth,
                DateDeath = dateDeath
            });
            context.SaveChanges();
            return ResponseList.SUCCSES_ADD_NEW_ROW;
        }

        public string Delete(int id)
        {
            var author = context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null) return ResponseList.ERR_AUTHOR_NOT_EXISTS;

            context.Authors.Remove(author);

            context.SaveChanges();
            return ResponseList.SUCCSES_DEL_ROW;
        }

        public List<Author> GetList()
        {
            List<Author> listAuthor = context.Authors.ToList();

            return listAuthor;
        }
        public Author GetById(int id)
        {
            var author = context.Authors.FirstOrDefault(x => x.Id == id);

            return author;
        }
        public SelectList GetListNickName()
        {
            SelectList sl = new SelectList(GetList(), "Id", "NickName");

            return sl;
        }

        public string Update(int id, string surname, string name, string patronymic, string nickName, DateTime dateBirth, DateTime? dateDeath)
        {
            var author = context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null) return ResponseList.ERR_AUTHOR_NOT_EXISTS;

            if (dateDeath != null && dateBirth > dateDeath) return ResponseList.ERR_AUTHOR_BAD_DATE_BOD;
            if (nickName.Length < 3) return ResponseList.ERR_AUTHOR_NICKNAME_SHORT;

            author.Surname = surname;
            author.Name = name;
            author.Patronymic = patronymic;
            author.NickName = nickName;
            author.DateBirth = dateBirth;
            author.DateDeath = dateDeath;

            context.SaveChanges();
            return ResponseList.SUCCSES_EDIT_ROW;
        }
    }
}