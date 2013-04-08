using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.ChainOfResponsibility
{
    public class DigitalHandler : AbstractHandler
    {
        public DigitalHandler(AbstractHandler handler) : base(handler) { }

        public override void Handle()
        {
            //take care of text
            //base.textToHandle
            Console.WriteLine("DigitalHandler handled");

            base.doNext();

        }
    }
}
