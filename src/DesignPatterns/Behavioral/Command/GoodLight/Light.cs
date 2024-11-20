using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Command.GoodLight
{
    //Reciever Class
    public class Light
    {
        public void TurnOn(){
            System.Console.WriteLine("Light is on");
        }

        public void TurnOFF(){
            System.Console.WriteLine("Light is off");
        }

        public void Dim(){
            System.Console.WriteLine("Light is dim");
        }
    }
}