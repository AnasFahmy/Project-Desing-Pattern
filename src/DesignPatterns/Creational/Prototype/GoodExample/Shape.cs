using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Creational.Prototype.GoodExample
{
    public interface Shape
    {
        void Draw();
        Shape Duplicate();
    }
}