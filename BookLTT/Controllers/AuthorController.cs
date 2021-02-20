using BookLTT.DataBase.Models;
using BookLTT.Domain;
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
    }
}