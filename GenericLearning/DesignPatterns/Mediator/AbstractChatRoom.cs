using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Mediator
{
    public abstract class AbstractChatRoom
    {
        public abstract void Send(Participant participant, string message);

        public abstract void Register(Participant participant);
        

    }
}
