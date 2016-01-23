using CreationalDesignPatterns.Builder.Model.RobotParts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Model.RobotParts
{
    class RobotHead : RobotPart
    {
        public RobotHead(string type) : base($"Robot Head - {type}")
        {

        }
    }
}
