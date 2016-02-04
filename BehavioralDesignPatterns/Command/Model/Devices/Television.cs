using BehavioralDesignPatterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command.Model
{
    class Television : IElectronicDevice
    {
        int _volume = 0;

        public void Off()
        {
            Console.WriteLine("TV is OFF");
        }

        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void VolumeDown()
        {
            --_volume;
            Console.WriteLine($"TV Volume : {_volume}");
        }

        public void VolumeUp()
        {
            ++_volume;
            Console.WriteLine($"TV Volume : {_volume}");
        }
    }
}