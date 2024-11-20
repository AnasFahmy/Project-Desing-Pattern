using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.OopPrinciples.Coupling
{
    public class SMSsender : NotificationService
    {

        public void SendNotification(string message)
        {
            System.Console.WriteLine("SMS message:" + message);
        }
    }
}