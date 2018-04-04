using JoesCoffeeStore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JoesCoffeeStore.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CoffeeDetails()
        {
            return View();
        }

        public IActionResult AllCoffees()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout([FromForm]CheckoutViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
