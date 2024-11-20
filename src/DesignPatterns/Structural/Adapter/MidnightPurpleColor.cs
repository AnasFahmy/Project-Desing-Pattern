using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Structural.Adapter
{
    public class MidnightColor : Color
    {
        public void Apply(Video video)
        {
            System.Console.WriteLine("Applying midnight-purple color to video"); ;
        }
    }
}