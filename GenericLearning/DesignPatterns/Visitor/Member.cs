using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public class Member : Customer
    {
        public void doMember(){}

        public override void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
