using BehavioralDesignPatterns.ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility.Interface
{
    interface IFileHandler
    {
        void SetNext(IFileHandler chain);

        void Handle(File file);
    }
}
