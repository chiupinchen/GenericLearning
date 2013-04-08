using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Mediator
{
    public class Participant 
    {
        public AbstractChatRoom ChatRoom {get;set;}

        

        public Participant(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void Send(string message)
        {
            ChatRoom.Send(this, message);
        }

        public virtual void Recevie(Participant participant, string message){
        
        }



    }
}
