using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.SOLID.O
{
    public class Rectangle : Shape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Lenght * Width;
        }
    }
}