using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLTT.Domain
{
    public static class ResponseList
    {
        public static string ERR_AUTHOR_BAD_DATE_BOD = "Дата смерти не может быть меньше даты рождения";

        public static string ERR_AUTHOR_NICKNAME_SHORT = "ФИО не может быть короче, чем 3 символа";

        public static string SUCCSES_ADD_NEW_ROW = "Новая запись успешно добавлена";

        public static string SUCCSES_DEL_ROW = "Запись успешно удалена";

        public static string SUCCSES_EDIT_ROW = "Запись успешно изменена";

        public static string ERR_AUTHOR_NOT_EXISTS = "Автор с таким id не существует";

        public static string ERR_BOOK_BAD_DATE = "Дата печати не может быть больше текущей даты";

        public static string ERR_BOOK_TITLE_SHORT= "Название не может быть короче 5 символов";

        public static string ERR_BOOK_BAD_PRICE = "Цена не может быть меньше 0";

        public static string ERR_BOOK_PUBLISHING_SHORT = "Наименование издательства не может быть короче 5 символов";

        public static string ERR_BOOK_BAD_EDITION = "Тираж не может быть меньше 1";

        public static string ERR_BOOK_NOT_EXISTS = "Книга с таким id не существует";

    }
}