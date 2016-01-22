using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility.Model
{
    class File
    {
        public File(string name, string extention)
        {
            Extention = extention;
            Name = name;
        }

        public string Name { get; private set; }
        public string Extention { get; private set; }
    }
}
