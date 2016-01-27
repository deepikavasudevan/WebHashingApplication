using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;

namespace WebHashApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
               Stopwatch stopwatch = new Stopwatch();
            Dictionary<int, int> sampleHashTable = new Dictionary<int, int>();
            stopwatch.Start();
            
            for (int i = 0; i <= 100000; i++) {
               sampleHashTable.Add(i, i);
            }
            
            stopwatch.Stop();
            Console.WriteLine("TIME ELAPSED IS" + stopwatch.Elapsed);
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
           
            return View();
        }

        public IActionResult Contasct()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
