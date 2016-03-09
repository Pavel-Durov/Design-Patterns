using CreationalDesignPatterns.Prototype.ColorExample.Model.Base;
using System;

namespace CreationalDesignPatterns.Prototype.ColorExample.Model
{
    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine($"Cloning RGB color: {_red},{_green},{_blue}");

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
