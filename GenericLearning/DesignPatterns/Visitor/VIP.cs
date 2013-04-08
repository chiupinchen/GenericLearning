using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public class VIP : Customer
    {
        public void doVIP() { }

        public override void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
