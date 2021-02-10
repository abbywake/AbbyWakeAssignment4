using AbbyWakeAssignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAssignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult confirmation()
        {
            return View();
        }

        public IActionResult viewAddRes()
        {
            return View(tempStorage.Applications);
        }

        public IActionResult Index()
        {
            List<string> ResList = new List<string>();

            foreach(Resturaunt r in Resturaunt.GetResturaunts())
            {
                ResList.Add(string.Format($"Rank #{r.Rank}:  {r.ResName}, {r.FavDish}, {r.ResPhone}, {r.Address}, {r.Link}"));

            }

            return View(ResList);
        }

        [HttpGet ("AddResturaunt")]
        public IActionResult addRest()
        {
            return View();
        }
        [HttpPost("AddResturaunt")]
        public IActionResult addRest(addRes addResturaunt)
        {

            tempStorage.AddApplication(addResturaunt);
            return View("confirmation", addResturaunt);
      
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
