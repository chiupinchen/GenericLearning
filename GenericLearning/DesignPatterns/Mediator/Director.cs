using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Mediator
{
    public class Director : Participant
    {

        public Director(string name)
            : base(name)
        { }

        public override void Recevie(Participant participant, string message)
        {
            Console.WriteLine("Get message from " + participant.Name + ": " + message + "!! Yes. Sir! I am " + this.Name);
        }
    }
}
