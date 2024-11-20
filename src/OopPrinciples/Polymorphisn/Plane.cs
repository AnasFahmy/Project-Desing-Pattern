using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.OopPrinciples.Polymorphisn
{
  public class Plane : Vehicle
  {
    public int NumberOfDoors { get; set; }

    public override void Start()
    {
      Console.WriteLine("Plane is starting.");
    }

    public override void Stop()
    {
      Console.WriteLine("Plane is stopping.");
    }

  }
}