using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.src.DesignPatterns.Creational.FactoryMethod.GoodExample.TwigFramwork;

namespace Project.src.DesignPatterns.Creational.FactoryMethod.GoodExample.BackendFramework
{
    public class TwigController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new TwigViewEngine();
        }
    }
}