using BehavioralDesignPatterns.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command.Model
{
    class DeviceButton
    {
        public DeviceButton(ICommand command, string content)
        {
            _command = command;
            Content = content;
        }


        public void Press()
        {
            _command.Execute();          
        }

        ICommand _command;
        public string Content { get; private set; }
    }
}
