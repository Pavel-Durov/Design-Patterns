
using CreationalDesignPatterns.Prototype.ColorExample.Model;
using CreationalDesignPatterns.Prototype.Model;
using System;

namespace CreationalDesignPatterns.Prototype.ColorExample
{
    class Test
    {
        public static void Run()
        {
            ColorPalette palette = new ColorPalette();

            palette["red"] = new Color(255, 0, 0);
            palette["green"] = new Color(0, 255, 0);
            palette["blue"] = new Color(0, 0, 255);


            // User clones selected colors
            Color red_clone = palette["red"].Clone() as Color;
            Color green_clone = palette["green"].Clone() as Color;
            Color blue_clone = palette["flame"].Clone() as Color;
        }
    }
}
