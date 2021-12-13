using Microsoft.AspNetCore.Mvc;
using MostafaProject.Models;

namespace MostafaProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;

        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Login()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (ModelState.IsValid && MostafaProject.Const.Admin.user == admin.Name && MostafaProject.Const.Admin.pass == admin.Pass)
            {
                return RedirectToAction("Index","Admin");
            }

            ModelState.AddModelError("Name", "لطفا مشخصات صحیح وارد کنید");
            return View(admin);

        }

        public IActionResult Index()
        {
            var book = MostafaProject.Const.Books.books.Where(p=>p.IsDelete == true).ToList();

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            book.Id = MostafaProject.Const.Books.id + 1;
            MostafaProject.Const.Books.books.Add(book);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var book = MostafaProject.Const.Books.books.FirstOrDefault(p=>p.Id == id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            MostafaProject.Const.Books.books[book.Id] = book;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            MostafaProject.Const.Books.books[id].IsDelete = false;

            return RedirectToAction("Index");
        }
    }
}
