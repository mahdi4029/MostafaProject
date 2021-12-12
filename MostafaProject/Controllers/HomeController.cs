using Microsoft.AspNetCore.Mvc;
using MostafaProject.Models;
using System.Diagnostics;

namespace MostafaProject.Controllers
{
    public class HomeController : Controller
    {


        List<Book> books = new List<Book> {

            new Book { BookName = "داستانی" , Author = "مصطفی",Description = "این کتاب مربوط به داستان های جذاب دوران قاجار است",Price = 15000},
            new Book { BookName = "سیاسی" , Author = "مصطفی",Description = "این کتاب مربوط به سیاست های غلط رضاخان هست",Price = 20000},
            new Book { BookName = "اجتماعی" , Author = "مصطفی",Description = "این کتاب درباره موضوعات اجتماعی دولت شاه است",Price = 30000},

            };

        public IActionResult Index()
        {

            return View(books);
        }

        public IActionResult DetailBook(String name)
        {
            var book = books.FirstOrDefault(x => x.BookName == name);

            return View(book);
        }

        public IActionResult Success(string name)
        {
            var book = books.FirstOrDefault(x => x.BookName == name);

            return View(book);
        }

    }
}