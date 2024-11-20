using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.SOLID.S
{
    public class UserService
    {
        public void Register(User user)
        {
            //Register user logic

            //send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to out platform");
            
        } 
    }
}