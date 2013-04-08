using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Member member);

        void Visit(VIP vip);

    }
}
