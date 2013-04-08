using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.ChainOfResponsibility
{
    public abstract class AbstractHandler
    {
        private AbstractHandler nextHandler;

        protected string textToHandle;

        public string TextToHandle
        {
            set;
            get;
        }


        public AbstractHandler(AbstractHandler handler)
        {
            nextHandler = handler;
        }

        public void doNext()
        {
            if (nextHandler != null)
            {
                nextHandler.Handle();
            }
        }

        public abstract void Handle();
        

    }
}
