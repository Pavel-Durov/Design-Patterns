using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Visitor.Interfaces
{
    interface IVisitable
    {
        void Accept(IProductVisitor visitor);
    }
}
