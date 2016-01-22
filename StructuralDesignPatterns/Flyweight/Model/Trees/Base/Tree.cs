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
        public Tree(Texture texture, ConsoleColor barkColor, ConsoleColor leafColor, double height, double width)
        {
            this.Texture = texture;
            this.Thickness = Thickness;
            this.Height = height;
            this.BarkColor = barkColor;
            this.LeafColor = leafColor;
            this.Thickness = width;
        }

        protected bool _alreadyRendered;

        public Texture Texture { get; private set; }
        public double Thickness { get;  set; }
        public double Height { get;  set; }
        public ConsoleColor BarkColor { get; private  set; }
        public ConsoleColor LeafColor { get; private  set; }

        public virtual async Task Render()
        {
            //..
        }
    }


}
