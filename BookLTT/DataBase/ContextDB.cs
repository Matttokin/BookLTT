using BookLTT.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookLTT.DataBase
{
    public class ContextDB : DbContext
    {
        public ContextDB()
            : base("DBConnection")
        { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}