using Microsoft.AspNetCore.Mvc;

namespace MostafaProject.Controllers
{
    public class BuyController : Controller
    {
        public IActionResult Basket()
        {
            if(MostafaProject.Const.Basket.Baskets != null)
            {
                var book = MostafaProject.Const.Basket.Baskets.ToList();
                return View(book);
            }

            return View();

            
        }
    }
}
