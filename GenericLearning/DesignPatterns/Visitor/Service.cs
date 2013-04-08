using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public class Service
    {

        public Service() { }


        public void doService()
        {
            IVisitor visitor = new VisitorImpl();
            Customer customer = new VIP();

            customer.doCustomer1();
            ((IVisitable)customer).accept(visitor);
            customer.doCustomer2();
        }

    }
}
