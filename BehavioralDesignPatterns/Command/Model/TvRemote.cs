using BehavioralDesignPatterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command.Model
{
    class TvRemote
    {
        public TvRemote(IElectronicDevice device)
        {
            _device = device;
        }

        IElectronicDevice _device;

        private void InitButtons()
        {
            VolumeUp = new DeviceButton(new Commands.VolumeUpTvCommand(_device), "Volume Up");
            VolumeDown = new DeviceButton(new Commands.VolumeDownTvCommand(_device), "Volume Down");
            On = new DeviceButton(new Commands.TurnTvOnCommand(_device), "On");
            Off = new DeviceButton(new Commands.TurnTvOffCommand(_device), "Off");
        }

        public DeviceButton VolumeUp{ get;private set; }
        public DeviceButton VolumeDown { get; private set; }
        public DeviceButton On { get; private set; }
        public DeviceButton Off { get; private set; }
    }
}
