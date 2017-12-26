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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
