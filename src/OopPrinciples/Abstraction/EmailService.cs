 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;

namespace Project.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending email...");
            Disconnect();
        }

        // ALL THE BELOW METHODS ARE PRIVATE -- THEY ARE NOT EXPOSED TO OTHER CLASSES. OTHER CLASSES JUST WANT TO SEND EMAILS, NO NEED FOR THEM TO SEE ALL THE COMPLEX DETAILS OF CONNECTING TO MAIL SERVER, AUTHENTICATING, DISCONNECTING.
        // we make those private to protect them and we add them to SendEmail method instead of adding them to Program.cs
        
        private void Connect()
        {
            System.Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            System.Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            System.Console.WriteLine("Disconnecting from email server...");
        }
    }
}
