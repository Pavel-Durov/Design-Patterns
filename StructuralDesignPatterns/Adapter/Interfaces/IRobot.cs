using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Interfaces
{
    interface IRobot
    {

        void WalkForward();

        void GoToDock();

        void TurnLeft();

        void ReactToHuman(string name);
    }
}
