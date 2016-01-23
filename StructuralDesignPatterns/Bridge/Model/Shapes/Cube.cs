using StructuralDesignPatterns.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.Model.Shapes
{
    class Cube : DrawableShape
    {
        public Cube(DrawingAPI api, double x, double y, double width) : base(api)
        {
            TopLeftX = x;
            TopLeftY = y;
            Width = width;
        }

  

        public double TopLeftX { get; private set; }
        public double TopLeftY { get; private set; }

        public double Width { get; private set; }

        public override void ResizeByPercentage(double percent)
        {
            Width *= percent;
        }

        public override void Draw()
        {
            _api.Draw(this);
        }

        public override string ToString()
        {
            return $"Cube : at ({TopLeftX}, {TopLeftY}) , Width : {Width} ";
        }
    }
}
