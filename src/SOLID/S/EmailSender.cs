using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            System.Console.WriteLine($"Sending Email to {email}: {message}");
            
        }
    }
}