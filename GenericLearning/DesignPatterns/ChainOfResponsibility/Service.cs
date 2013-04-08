using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.ChainOfResponsibility
{
    public class Service
    {
        public void doService()
        {
            AbstractHandler handler = new CharacterHandler(new DigitalHandler(null));
            handler.TextToHandle = "abc123xyz";

            handler.Handle();
        }

    }
}
