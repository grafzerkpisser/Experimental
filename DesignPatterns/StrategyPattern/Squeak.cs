using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void MakeNoise()
        {
            Console.WriteLine("Squeak, squeak, squeak");
        }
    }
}