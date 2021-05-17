using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGenerator.MVC.dnc.Controllers
{
    public class ViewInjectionController : Controller
    {
        // GET: ViewInjectionController
        [HttpGet]
        public ActionResult Index(string generatorType)
        {
            // set dropdown value
            ViewBag.GeneratorType = generatorType;
            return View();
        }

        // POST: ViewInjectionController
        [HttpPost]
        public ActionResult Index(IFormCollection form)
        {
            var value = form["GeneratorType"].ToString();
            // set dropdown value
            ViewBag.GeneratorType = value;

            return View();
        }
    }
}
