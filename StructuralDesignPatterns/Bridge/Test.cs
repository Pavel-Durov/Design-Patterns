using StructuralDesignPatterns.Bridge.Model.DrawingAPIs;
using StructuralDesignPatterns.Bridge.Model.Shapes;

namespace StructuralDesignPatterns.Bridge
{
    class Test
    {
        public static void Run()
        {
            var api2d = new ShapeDrawing2d();
            var api3d = new ShapeDrawing3d();
            var shapesArr = new DrawableShape[]{
                new Circle(api2d, 1, 3, 7),
                new Circle(api3d, 1, 3, 7),
                new Cube(api3d,5, 7, 11),
                new Cube(api2d,15, 57, 11)
            };

            foreach (var shape in shapesArr)
            {
                shape.Draw();
            }

        }
    }
}
