using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Creational.AbstractFactory.BadExample.Mac
{
    // /Mac/MacCheckbox.cs
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("Mac: render checkbox");
        }
    }
}