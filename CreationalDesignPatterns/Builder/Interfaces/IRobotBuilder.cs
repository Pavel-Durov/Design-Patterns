using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Builder.Model;

namespace CreationalDesignPatterns.Builder.Interfaces
{
    interface IRobotBuilder
    {
        Robot Robot { get; }

        void BuildRobotHead();
        void BuildRobotArms();
        void BuildRobotLegs();
        void BuildRobotTorso();
 
    }
}
