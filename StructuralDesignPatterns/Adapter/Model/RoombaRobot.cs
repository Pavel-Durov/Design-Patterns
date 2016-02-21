using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Model
{
    internal class RoombaRobot 
    {
        public RoombaRobot()
        {

        }


        const int _step = 3;
        const int _turnAngle = 90;
 
        public void AdvanceForward()
        {
            Console.WriteLine($"Robot walks {_step} steps");
        }

        public void GoToSleep()
        {
            Console.WriteLine("Robot distenation set to docking station");
        }

        public void Turn()
        {
            Console.WriteLine($"Turning left by {_turnAngle } angle");
        }

        public void DetectHuman(string name)
        {
            Console.WriteLine("Human detected...");
        }
    }
}
