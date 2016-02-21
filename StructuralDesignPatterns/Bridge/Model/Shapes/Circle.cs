using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Bridge.Interfaces;

namespace StructuralDesignPatterns.Bridge.Model.Shapes
{
    class Circle : DrawableShape
    {

        public Circle(IDrawingAPI api, double x, double y, double radius) : base(api)
        {
            CenterX = x;
            CenterY = y;
            Radius = radius;
        }


        public double CenterX { get; private set; }
        public double CenterY { get; private set; }

        public double Radius { get; private set; }

        public override void ResizeByPercentage(double percent)
        {
            Radius += percent;
        }
        

        public override string ToString()
        {
            return $"Circle : at ({CenterX}, {CenterY}) , Radius : {Radius} ";
        }
    }
}
