using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.ChainOfResponsibility
{
    public class CharacterHandler: AbstractHandler
    {
        public CharacterHandler(AbstractHandler handler) : base(handler) { }

        public override void Handle()
        {
            //take care of text
            //base.textToHandle
            Console.WriteLine("CharacterHandler handled");

            base.doNext();

        }

    }
}
