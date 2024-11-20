using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.DesignPatterns.Behavioral.State.Overkill
{
    public class Stopwatch
    {
        private bool IsRunning { get; set; } = false;

        public void click()
        {
            if (IsRunning)
            {
                IsRunning = false;
                System.Console.WriteLine("Stopped");
            }
            else
            {
                IsRunning = true;
                System.Console.WriteLine("Running");
            }
        }
    }
}