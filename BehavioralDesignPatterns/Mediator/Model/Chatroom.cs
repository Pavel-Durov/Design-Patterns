using System;
using System.Collections.Generic;

namespace BehavioralDesignPatterns.Mediator.Model
{
    public class Chatroom 
    {
        private Dictionary<Guid, ChatRoomParticipant> _participants = new Dictionary<Guid, ChatRoomParticipant>();

        public void Register(ChatRoomParticipant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                var id = Guid.NewGuid();
                _participants[id] = participant;
                participant.ID = id;
            }

            participant.Chatroom = this;
        }

        public void Send(Guid senderId, Guid recieverId, string message)
        {
            ChatRoomParticipant reciever = _participants[recieverId];
            ChatRoomParticipant sender = _participants[senderId];
            
            if (reciever != null && sender != null)
            {
                reciever.Receive(sender.NickName, message);
            }
        }
    }
}
