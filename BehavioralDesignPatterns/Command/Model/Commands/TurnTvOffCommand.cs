using BehavioralDesignPatterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command.Model.Commands
{
    class TurnTvOffCommand : ICommand
    {
        public TurnTvOffCommand(IElectronicDevice device)
        {
            _device = device;
        }

        IElectronicDevice _device;

        public void Execute()
        {
            _device.Off();
        }
    }
}
