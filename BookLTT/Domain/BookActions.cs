using BookLTT.DataBase;
using BookLTT.DataBase.Models;
using BookLTT.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookLTT.Domain
{
    public class BookActions : IBook
    {
        private ContextDB context;
        public BookActions()
        {
            context = new ContextDB();
        }

        public bool Add(string title, int authorId, double price, DateTime datePrint, string publishing, int edition)
        {
            var authorRow = context.Authors.FirstOrDefault(x => x.Id == authorId);
            if (authorRow == null) return false;

            context.Books.Add(new Book() {
                Title = title,
                AuthorId = authorRow.Id,
                Price = price,
                DatePrint = datePrint,
                Publishing = publishing,
                Edition = edition
            });
            context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null) return false;

            context.Books.Remove(book);

            context.SaveChanges();
            return true;
        }

        public Book GetById(int id)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == id);

            return book;
        }

        public List<Book> GetList()
        {
            List<Book> listBook = context.Books.Include(x => x.Author).ToList();

            return listBook;
        }

        public bool Update(int id, string title, int authorId, double price, DateTime datePrint, string publishing, int edition)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null) return false;

            var authorRow = context.Authors.FirstOrDefault(x => x.Id == authorId);
            if (authorRow == null) return false;

            book.Title = title;
            book.AuthorId = authorRow.Id;
            book.Price = price;
            book.DatePrint = datePrint;
            book.Publishing = publishing;
            book.Edition = edition;

            /*book = new Book()
            {
                Title = title,
                AuthorId = authorRow.Id,
                Price = price,
                DatePrint = datePrint,
                Publishing = publishing,
                Edition = edition
            };*/

            context.SaveChanges();
            return true;
        }
    }
}