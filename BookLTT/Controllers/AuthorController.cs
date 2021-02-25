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
    public class AuthorController : Controller
    {
        private AuthorActions aAct = new AuthorActions();
        public ActionResult Index()
        {
            List<Author> listAuthor = aAct.GetList();
            return View(listAuthor);
        }
        public ActionResult Create()
        {
            ViewBag.Result = "";
            return View();
        }
        public ActionResult Edit(int id)
        {
            Author author = aAct.GetById(id);
            ViewBag.Result = "";
            return View(author);
        }
        public RedirectResult Delete(int id)
        {
            var result = aAct.Delete(id);
            return Redirect("/Author/Index");
        }
        public ActionResult Details(int id)
        {
            Author author = aAct.GetById(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult Create(CreateAuthorViewModel author)
        {
            var result = aAct.Add(author.Surname, author.Name, author.Patronymic, author.NickName, author.DateBirth, author.DateDeath);
            ViewBag.Result = result;

            return View();
        }
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            var result = aAct.Update(author.Id, author.Surname, author.Name, author.Patronymic, author.NickName, author.DateBirth, author.DateDeath);
            ViewBag.Result = result;

            return View();
        }
    }
}