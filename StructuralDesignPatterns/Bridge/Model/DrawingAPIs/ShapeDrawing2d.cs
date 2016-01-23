using StructuralDesignPatterns.Bridge.Interfaces;
using StructuralDesignPatterns.Bridge.Model.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge.Model.DrawingAPIs
{
    class ShapeDrawing2d : DrawingAPI
    {
        public void Draw(DrawableShape shape)
        {
            Console.WriteLine("-- Drawing 2D Shape -- ");
            Console.WriteLine(shape);
            Console.WriteLine("------------------------");
        }
    }
}
