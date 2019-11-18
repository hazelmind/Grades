using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Grade.Models;

namespace Grade.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

        //could add bool here if there was a curve on text
        public IActionResult FindGrade(UserInput userInput)
        {
            decimal tPoints = userInput.TotalPoints;
            decimal tCorrect = userInput.TotalCorrect;
            decimal gradeDec = tCorrect / tPoints;
            decimal gradePer= gradeDec * 100;
            return View(gradePer);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
