using GameGenerator.Library.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameGenerator.MVC.dnc.Models
{
    public class GeneratorData
    {
        public SelectList GeneratorList { get; set; }
        public IAbstractGenerator? Generator { get; set; }
    }
}
