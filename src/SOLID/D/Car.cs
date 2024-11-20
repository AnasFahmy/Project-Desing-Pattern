using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.SOLID.D
{
    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = new Engine(); // Direct dependency on Engine class
        }

        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}