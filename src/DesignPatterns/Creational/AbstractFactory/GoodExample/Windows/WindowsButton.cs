using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Creational.AbstractFactory.GoodExample.Windows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("Windows: render button");
        }
    }
}