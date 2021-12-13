using Microsoft.AspNetCore.Mvc;
using MostafaProject.Models;
using System.Diagnostics;

namespace MostafaProject.Controllers
{
    public class HomeController : Controller
    {


        

        public IActionResult Index()
        {

            return View(MostafaProject.Const.Books.books.Where(p=>p.IsDelete == true).ToList());
        }

        public IActionResult DetailBook(string? name)
        {

            if (MostafaProject.Const.BuyId.Id != 0)
            {
                var bookName = MostafaProject.Const.Books.books.FirstOrDefault(p=>p.Id==MostafaProject.Const.BuyId.Id).BookName;

                var book = MostafaProject.Const.Books.books.FirstOrDefault(x => x.BookName == bookName);
                return View(book);
            }
            else
            {
                var book = MostafaProject.Const.Books.books.FirstOrDefault(x => x.BookName == name);
                return View(book);
            }
             
        }

        public IActionResult Success(string name)
        {
            var book = MostafaProject.Const.Books.books.FirstOrDefault(x => x.BookName == name);

            return View(book);
        }

    }
}