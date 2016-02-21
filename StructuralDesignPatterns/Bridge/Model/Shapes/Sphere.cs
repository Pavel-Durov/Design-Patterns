using StructuralDesignPatterns.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.Model.Shapes
{
    class Sphere : DrawableShape
    {
        public Sphere(IDrawingAPI api, double x, double y, double radius) : base(api)
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
            return $"Sphere : at ({CenterX}, {CenterY}) , Radius : {Radius} ";
        }
    }
}
