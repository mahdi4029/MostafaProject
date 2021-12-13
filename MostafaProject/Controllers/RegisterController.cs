using Microsoft.AspNetCore.Mvc;
using MostafaProject.Models;

namespace MostafaProject.Controllers
{

    public class RegisterController : Controller
    {
        User _user = new User();

        public IActionResult Register(int id)
        {
            MostafaProject.Const.BuyId.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _user.Name = user.Name;
                _user.Family = user.Family;
                _user.Mobile = user.Mobile;
                _user.PassWrod = user.PassWrod;
                _user.RePassWrod = user.RePassWrod;
                MostafaProject.Const.Auth.Name = _user.Name;
                MostafaProject.Const.Auth.Family = _user.Family;
                MostafaProject.Const.Auth.Mobile = _user.Mobile;
                MostafaProject.Const.Auth.PassWord = _user.PassWrod;

                return RedirectToAction("DetailBook" ,"Home");
            }

            return View(user);
        }
    }
}
