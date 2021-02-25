using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLTT.DataBase.Models
{
    public class Book
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        [DisplayName("Дата печати")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]        
        public DateTime DatePrint { get; set; }
        [DisplayName("Издательство")]
        public string Publishing { get; set; }
        [DisplayName("Тираж")]
        public int Edition { get; set; }
    }
}