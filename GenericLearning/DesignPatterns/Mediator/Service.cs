using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Mediator
{
    public class Service
    {
        public void doService()
        {
            AbstractChatRoom chatRoom = new ChatRoom();


            Participant p1 = new Director("Jason");
            Participant p2 = new Director("Rob");
            Participant p3 = new Director("Lance");
            Participant p4 = new VP("Chris");


            chatRoom.Register(p1);
            chatRoom.Register(p2);
            chatRoom.Register(p3);
            chatRoom.Register(p4);

            p4.Send("Let's do ProjectA");

            p1.Send("I take care of software development");

        }
    }
}
