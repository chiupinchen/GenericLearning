using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public class Customer : IVisitable
    {
        public void doCustomer1(){}

        public void doCustomer2() { }

        public virtual void accept(IVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
