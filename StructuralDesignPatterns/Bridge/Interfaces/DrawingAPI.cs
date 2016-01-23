using StructuralDesignPatterns.Bridge.Model.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.Interfaces
{
    interface DrawingAPI
    {
        void Draw(DrawableShape shape);
    }
}
