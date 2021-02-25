using BookLTT.DataBase.Models;
using BookLTT.Domain;
using BookLTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLTT.Controllers
{
    public class BookController : Controller
    {
        private BookActions bAct = new BookActions();
        private AuthorActions aAct = new AuthorActions();
        public ActionResult Index()
        {
            List<Book> listBook = bAct.GetList();
            return View(listBook);
        }
        public ActionResult Details(int id)
        {
            Book book = bAct.GetById(id);
            return View(book);
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Authors = aAct.GetListNickName();
            Book book = bAct.GetById(id);
            ViewBag.Result = "";
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            ViewBag.Authors = aAct.GetListNickName();
            var result = bAct.Update(book.Id, book.Title, book.AuthorId, book.Price, book.DatePrint, book.Publishing, book.Edition);
            ViewBag.Result = result;

            return View();
        }
        public RedirectResult Delete(int id)
        {
            var result = bAct.Delete(id);
            Console.WriteLine(result);
            return Redirect("/Book/Index");
        }
        public ActionResult Create()
        {
            ViewBag.Authors = aAct.GetListNickName();
            ViewBag.Result = "";
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateBookViewModel book)
        {            
            ViewBag.Authors = aAct.GetListNickName(); 

            var result = bAct.Add(book.Title, book.AuthorId, book.Price, book.DatePrint, book.Publishing, book.Edition);
            ViewBag.Result = result;

            return View();
        }
    }
}