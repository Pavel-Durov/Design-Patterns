using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Mediator.Model
{
    public class ChatRoomParticipant
    {
        public ChatRoomParticipant(string nick)
        {
            this.NickName = nick;
        }

        public string NickName
        {
            get; private set;
        }

        public Chatroom Chatroom { get; set; }

        public Guid ID { get; set; }


        public void Send(Guid to, string message)
        {
            Chatroom.Send(this.ID, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {NickName}: '{message}'");
        }
    }
}
