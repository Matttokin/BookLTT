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

        public string Add(string title, int authorId, double price, DateTime datePrint, string publishing, int edition)
        {
            var authorRow = context.Authors.FirstOrDefault(x => x.Id == authorId);
            if (authorRow == null) return ResponseList.ERR_AUTHOR_NOT_EXISTS;

            if (datePrint > DateTime.Today) return ResponseList.ERR_BOOK_BAD_DATE;
            if (title.Length < 5) return ResponseList.ERR_BOOK_TITLE_SHORT;
            if (price < 0) return ResponseList.ERR_BOOK_BAD_PRICE;
            if (publishing.Length < 5) return ResponseList.ERR_BOOK_PUBLISHING_SHORT;
            if (edition < 1) return ResponseList.ERR_BOOK_BAD_EDITION;

            context.Books.Add(new Book() {
                Title = title,
                AuthorId = authorRow.Id,
                Price = price,
                DatePrint = datePrint,
                Publishing = publishing,
                Edition = edition
            });
            context.SaveChanges();
            return ResponseList.SUCCSES_ADD_NEW_ROW;
        }

        public string Delete(int id)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null) return ResponseList.ERR_BOOK_NOT_EXISTS;

            context.Books.Remove(book);

            context.SaveChanges();
            return ResponseList.SUCCSES_DEL_ROW;
        }

        public Book GetById(int id)
        {
            var book = context.Books.Include(x => x.Author).FirstOrDefault(x => x.Id == id);

            return book;
        }

        public List<Book> GetList()
        {
            List<Book> listBook = context.Books.Include(x => x.Author).ToList();

            return listBook;
        }

        public string Update(int id, string title, int authorId, double price, DateTime datePrint, string publishing, int edition)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == id);
            if (book == null) return ResponseList.ERR_BOOK_NOT_EXISTS;

            var authorRow = context.Authors.FirstOrDefault(x => x.Id == authorId);
            if (authorRow == null) return ResponseList.ERR_AUTHOR_NOT_EXISTS;

            if (datePrint > DateTime.Today) return ResponseList.ERR_BOOK_BAD_DATE;
            if (title.Length < 5) return ResponseList.ERR_BOOK_TITLE_SHORT;
            if (price < 0) return ResponseList.ERR_BOOK_BAD_PRICE;
            if (publishing.Length < 5) return ResponseList.ERR_BOOK_PUBLISHING_SHORT;
            if (edition < 1) return ResponseList.ERR_BOOK_BAD_EDITION;

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
            return ResponseList.SUCCSES_EDIT_ROW;
        }
    }
}