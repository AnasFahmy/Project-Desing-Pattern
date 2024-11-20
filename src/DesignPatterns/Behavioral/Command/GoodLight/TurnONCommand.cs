using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Command.GoodLight
{
    //Reciever Class
    public class TurnONCommand : ICommand
    {
        private Light _light;
        public TurnONCommand(Light light){
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
}