using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Structural.Bridge.GoodExample
{
    public interface Device
    {
        public void TurnOn();

        public void TurnOff();

        public void SetChannel(int channel);
    }
}