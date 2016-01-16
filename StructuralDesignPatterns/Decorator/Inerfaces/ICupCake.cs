using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator.Interfaces 
{
    public interface ICupcake
    {
        string Description { get; }

        double Cost { get; }
    }
}
