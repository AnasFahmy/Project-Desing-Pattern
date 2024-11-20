using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.Command
{
    //Reciever Class
    public class RemoteControl
    {
        private Light _light;

        public RemoteControl(Light light){
            _light = light;
        }

        public void PressButton(bool turnOn){
            if(turnOn){
                _light.TurnOn();
            }
            else{
                _light.TurnOFF();
            }
        }
    }
}