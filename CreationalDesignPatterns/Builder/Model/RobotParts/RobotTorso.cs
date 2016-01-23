using CreationalDesignPatterns.Builder.Model.RobotParts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Model.RobotParts
{
    class RobotTorso : RobotPart
    {
        public RobotTorso(string type) : base($"Robot Torso- {type}")
        {

        }
    }
}
