using BehavioralDesignPatterns.Mediator.Model;
using System;

namespace BehavioralDesignPatterns.Mediator
{
    class Test
    {
        public static void Run()
        {
            Chatroom chatroom = new Chatroom();

            var Shalom = new ChatRoomParticipant("Shalom");
            var David = new ChatRoomParticipant("David");
            var King = new ChatRoomParticipant("King");
            var Jam = new ChatRoomParticipant("Raspberry Jam");

            chatroom.Register(Shalom);
            chatroom.Register(David);
            chatroom.Register(King);
            chatroom.Register(Jam);

            //Chat functionality
            Shalom.Send(David.ID, "Hi David!");
            David.Send(Shalom.ID, "Hi there!");
            King.Send(Jam.ID, "Want to eat some pancakes?");
            Jam.Send(King.ID, "Yep!");

            // Wait for user
            Console.ReadKey();
        }
    }
}
