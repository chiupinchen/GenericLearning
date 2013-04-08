using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericLearning.DesignPatterns.Mediator
{
    public class ChatRoom : AbstractChatRoom
    {

        private List<Participant> participants;

        public ChatRoom()
        {
            participants = new List<Participant>();

        }

        public override void Register(Participant participant)
        {
            participants.Add(participant);

            participant.ChatRoom = this;
        }

      
        public override void Send(Participant participant, string message)
        {
            foreach (var p in participants)
            {
                if (p.Name != participant.Name)
                    p.Recevie(participant, message);
            }
        }
    }
}
