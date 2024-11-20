using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Creational.AbstractFactory.BadExample.Mac
{
    // Mac/MacButton
    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render button");
        }
    }
}