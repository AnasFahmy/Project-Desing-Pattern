using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Command.GoodLight
{
    //Reciever Class
    public class DimCommand : ICommand
    {
        private Light _light;
        public DimCommand(Light light){
            _light = light;
        }
        public void Execute()
        {
            _light.Dim();
        }
    }
}