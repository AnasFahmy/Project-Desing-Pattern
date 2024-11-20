using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Creational.AbstractFactory.GoodExample.Mac
{
    // /Mac/MacUIComponentFactory.cs
    public class MacUIComponentFactory : IUIComponentFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}