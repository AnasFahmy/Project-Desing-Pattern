using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.src.DesignPatterns.Creational.FactoryMethod.BadExample2.BackendFramework;

namespace Project.src.DesignPatterns.Creational.FactoryMethod.BadExample2.Blade
{
    public class BladeViewEngine : ViewEngine
    {
        public string Render(string fileName, Dictionary<string, object> data)
        {
            return "View rendered from " + fileName + " by Blade";
        }
    }
}