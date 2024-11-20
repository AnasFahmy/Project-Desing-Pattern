using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.OopPrinciples.Coupling
{
    public interface NotificationService
    {
        void SendNotification(string message);
    }
}