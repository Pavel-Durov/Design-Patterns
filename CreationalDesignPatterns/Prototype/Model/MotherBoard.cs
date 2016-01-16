using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Prototype.Model
{
    class MotherBoard
    {
        public string Brand { get; set; }
        public int USBPortsCount { get; set; }
        public int HasLanPort { get; set; }
    }
}
