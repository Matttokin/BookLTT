using BookLTT.DataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLTT.Models
{
    public class CreateBookViewModel
    {
        [DisplayName("Название")]
        public string Title { get; set; }
        [DisplayName("Автор")]
        public int AuthorId { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Дата печати")]
        public DateTime DatePrint { get; set; }
        [DisplayName("Издательство")]
        public string Publishing { get; set; }
        [DisplayName("Тираж")]
        public int Edition { get; set; }
    }
}