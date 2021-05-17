using GameGenerator.Library.Interfaces;
using GameGenerator.MVC.dnc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGenerator.MVC.dnc.Controllers
{
    public class ActionInjectionController : Controller
    {
        // GET: ActionInjectionController
        [HttpGet]
        public ActionResult Index([FromServices] IEnumerable<IAbstractGenerator> generators, string generatorType)
        {
            // set view model value
            ViewData.Model = new GeneratorData
            {
                GeneratorList = new SelectList(generators.Select(gen => gen.GetType().Name).ToArray()),
                Generator = generators.Where(gen => gen.GetType().Name.Equals(generatorType)).FirstOrDefault()
            };

            // set dropdown value
            ViewBag.GeneratorType = generatorType;
            return View();
        }

        // POST: ActionInjectionController
        [HttpPost]
        public ActionResult Index(IFormCollection form, [FromServices] IEnumerable<IAbstractGenerator> generators)
        {
            var generatorTypeName = form["GeneratorType"].ToString();
            // set view model value
            ViewData.Model = new GeneratorData
            {
                GeneratorList = new SelectList(generators.Select(gen => gen.GetType().Name).ToArray()),
                Generator = generators.Where(gen => gen.GetType().Name.Equals(generatorTypeName)).FirstOrDefault()
            };

            // set dropdown value
            ViewBag.GeneratorType = generatorTypeName;
            return View();
        }
    }
}
