using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Visitor
{
    public interface IVisitable
    {
        void accept(IVisitor visitor);
    }
}
