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
    public class ConstructorInjectionController : Controller
    {
        private readonly IEnumerable<IAbstractGenerator> _generators;
        private readonly SelectList _list;

        public ConstructorInjectionController(IEnumerable<IAbstractGenerator> genreators)
        {

            this._generators = genreators;
            this._list = new SelectList(_generators.Select(gen => gen.GetType().Name).ToArray());
        }

        // GET: ConstructorInjectionController
        [HttpGet]
        public ActionResult Index(string generatorType)
        {
            // set view model value
            ViewData.Model = new GeneratorData
            {
                GeneratorList = this._list,
                Generator = this._generators.Where(gen => gen.GetType().Name.Equals(generatorType)).FirstOrDefault()
            };

            // set dropdown value
            ViewBag.GeneratorType = generatorType;
            return View();
        }

        // POST: ConstructorInjectionController
        [HttpPost]
        public ActionResult Index(IFormCollection form)
        {
            var generatorTypeName = form["GeneratorType"].ToString();

            // set view model value
            ViewData.Model = new GeneratorData
            {
                GeneratorList = this._list,
                Generator = this._generators.Where(gen => gen.GetType().Name.Equals(generatorTypeName)).FirstOrDefault()
            };

            // set dropdown value
            ViewBag.GeneratorType = generatorTypeName;
            return View();
        }


    }
}
