using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly NotificationService notificationService;

        public Order(NotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            //Email sending logic
            notificationService.SendNotification("Order is placed Successgly");
        }   
    }
}