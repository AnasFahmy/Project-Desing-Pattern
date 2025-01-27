using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Creational.FactoryMethod.BadExample.BackendFramework
{
    public interface ViewEngine
    {
        string Render(string fileName, Dictionary<string, object> data);
    }
}