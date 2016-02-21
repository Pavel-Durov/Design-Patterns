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
        public DrawableShape(IDrawingAPI api)
        {
            _api = api;
        }

        protected IDrawingAPI _api;

        public virtual void Draw()
        {
            _api.Draw(this);
        }

        public abstract void ResizeByPercentage(double percent);
    }
}
