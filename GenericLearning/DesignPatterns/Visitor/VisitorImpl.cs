using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public class VisitorImpl : IVisitor
    {
        public void Visit(Member member)
        {
            member.doMember();
        }

        public void Visit(VIP vip)
        {
            vip.doVIP();
        }
    }
}
