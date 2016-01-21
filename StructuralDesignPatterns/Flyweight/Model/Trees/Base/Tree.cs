using StructuralDesignPatterns.Flyweight.Model.Textures.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight.Model
{
    abstract class Tree
    {
        public Tree(Texture texture, ConsoleColor barkColor, ConsoleColor leafColor, double height, double width, double x, double y)
        {
            this.Texture = texture;
            this.Thickness = Thickness;
            this.Height = height;
            this.BarkColor = barkColor;
            this.LeafColor = leafColor;
            this.X = x;
            this.Y = y;
        }

        public Texture Texture { get; private set; }
        public double Thickness { get; private set; }
        public double Height { get; private set; }
        public ConsoleColor BarkColor { get; private  set; }
        public ConsoleColor LeafColor { get; private  set; }

        public double X { get; private set; }
        public double Y { get; private set; }
    }


}
