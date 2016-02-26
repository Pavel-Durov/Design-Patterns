using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.ConstructionSite.Interfaces
{
    public interface IEmployee
    {
        void Work();
        void Break();
        string Description { get; }
    }

}
