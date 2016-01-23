using StructuralDesignPatterns.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.Model.Shapes
{
    abstract class DrawableShape
    {
        public DrawableShape(DrawingAPI api)
        {
            _api = api;
        }

        protected DrawingAPI _api;

        public abstract void Draw();

        public abstract void ResizeByPercentage(double percent);
    }
}
