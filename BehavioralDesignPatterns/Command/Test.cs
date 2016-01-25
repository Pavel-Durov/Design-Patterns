using BehavioralDesignPatterns.Command.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command
{
    class Test
    {
        public static void Run()
        {
            TvRemote remote = new TvRemote(new Television());

            remote.VolumeUp.Press();
            remote.VolumeDown.Press();
            remote.On.Press();
            remote.Off.Press();
            
            //remote.Buttons
        }
    }
}
