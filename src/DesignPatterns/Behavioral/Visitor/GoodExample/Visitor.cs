using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.src.DesignPatterns.Behavioral.Visitor.BadExample;

namespace Project.src.DesignPatterns.Behavioral.Visitor.GoodExample
{
    public interface Visitor
    {
        void VisitRetail(Retail retail);

        void VisitLaw(Law law);

        void VisitRestaurant(Restaurant restaurant);
    }
}