using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Controllers
{
    public class HomeController : Controller
    {
        string InfoMessage { get; set; } = "Witaj na stronie startowej!";
        public IActionResult Index()
        {
            InfoMessage += $" Aktualny czas to: {DateTime.Now} ";
            ViewBag.Message = InfoMessage;
            return RedirectToAction("Index", "Students");
        }
    }
}
