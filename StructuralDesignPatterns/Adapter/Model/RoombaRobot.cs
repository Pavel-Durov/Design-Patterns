using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    internal class RoombaRobot : IRobot
    {
        public RoombaRobot()
        {

        }


        const int _step = 3;
        const int _turnAngle = 90;
 
        public void WalkForward()
        {
            Console.WriteLine($"Robot walks {_step} steps");
        }

        public void GoToDock()
        {
            Console.WriteLine("Robot distenation set to docking station");
        }

        public void TurnLeft()
        {
            Console.WriteLine($"Turning left by {_turnAngle } angle");
        }

        public void ReactToHuman(string name)
        {
            Console.WriteLine("Human detected...");
        }
    }
}
