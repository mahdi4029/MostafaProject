using MostafaProject.Models;

namespace MostafaProject.Const
{
    public static class Books
    {
       public static int id = 2;
       public static List<Book> books = new List<Book> {

            new Book {Id = 0 , BookName = "داستانی" , Author = "مصطفی",Description = "این کتاب مربوط به داستان های جذاب دوران قاجار است",Price = 15000},
            new Book {Id = 1 , BookName = "سیاسی" , Author = "مصطفی",Description = "این کتاب مربوط به سیاست های غلط رضاخان هست",Price = 20000},
            new Book {Id = 2 , BookName = "اجتماعی" , Author = "مصطفی",Description = "این کتاب درباره موضوعات اجتماعی دولت شاه است",Price = 30000},

            };
    }
}
