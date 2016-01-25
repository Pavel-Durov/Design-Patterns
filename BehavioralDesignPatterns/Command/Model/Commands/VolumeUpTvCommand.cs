using BehavioralDesignPatterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command.Model.Commands
{
    class VolumeUpTvCommand : ICommand
    {
        public VolumeUpTvCommand(IElectronicDevice device)
        {
            _device = device;
        }

        IElectronicDevice _device;

        public void Execute()
        {
            _device.VolumeUp();
        }
    }
}
