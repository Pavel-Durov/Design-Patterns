using StructuralDesignPatterns.Decorator.Decorators;
using StructuralDesignPatterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Decorator.Model
{
    public class CupcakeSmartOven
    {
        public void GenerateCupcakes()
        {


            Console.WriteLine(" - GENERATING Sprinkles/Cream Cupcake Decorator - ");
            ICupcake creamSprinklesCupcake = 
                new CreamCupcakeDecorator(
                    new SprinklesCupcakeDecorator(
                        new PlainCupcake()));

            Console.WriteLine($"Generated : {creamSprinklesCupcake.Description}");


            Console.WriteLine(" - GENERATING Double Cream Cupcake Decorator - ");
            ICupcake doubleCreamCupcake = new CreamCupcakeDecorator(new CreamCupcakeDecorator(new PlainCupcake()));
            Console.WriteLine($"Generated : {doubleCreamCupcake.Description}");


            Console.WriteLine(" - GENERATING Sprinkles Cupcake - ");
            ICupcake sprinklesCupcake = new SprinklesCupcakeDecorator(new PlainCupcake());
            Console.WriteLine($"Generated : {sprinklesCupcake.Description}");


            Console.WriteLine(" - GENERATING Plain Cupcake - ");
            ICupcake plainCupcake = new PlainCupcake();
            Console.WriteLine($"Generated : {plainCupcake.Description}");


            var totalAmount =   creamSprinklesCupcake.Cost + 
                                doubleCreamCupcake.Cost + 
                                sprinklesCupcake.Cost + plainCupcake.Cost;
            Console.WriteLine($"Total cost: {totalAmount }");



        }
    }
}
