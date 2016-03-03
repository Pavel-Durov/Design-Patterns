using StructuralDesignPatterns.Proxy.BasicMathExample.Interfaces;
using System;

namespace StructuralDesignPatterns.Proxy.BasicMathExample.Model
{
    class BasicMathProxy : IBasicMath
    {
        public double Power(double firstNum, double secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }

        public double Round(double firstNum)
        {
            return Math.Round(firstNum);
        }

        public double Square(double firstNum)
        {
            return Math.Sqrt(firstNum);
        }
    }
}
