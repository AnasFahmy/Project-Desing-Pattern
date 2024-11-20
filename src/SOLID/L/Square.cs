using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.SOLID.L
{
    public class Square : Shape
    {
        public double SideLenght { get; set; }

        public override double Area => SideLenght * SideLenght;
    }
}