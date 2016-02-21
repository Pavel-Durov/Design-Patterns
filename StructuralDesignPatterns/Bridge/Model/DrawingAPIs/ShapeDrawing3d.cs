using StructuralDesignPatterns.Bridge.Interfaces;
using StructuralDesignPatterns.Bridge.Model.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.Model.DrawingAPIs
{
    class ShapeDrawing3d : IDrawingAPI
    {
        public void Draw(DrawableShape shape)
        {
            Console.WriteLine("-- Drawing 3D Shape -- ");
            Console.WriteLine(shape);
        }
    }
}
