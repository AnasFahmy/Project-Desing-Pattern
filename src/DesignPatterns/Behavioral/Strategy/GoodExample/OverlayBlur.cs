using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayBlur : IOverlay 
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying blur overlay");
        }
    }
}