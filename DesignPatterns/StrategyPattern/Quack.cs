using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class Quack : IQuackBehavior
    {
        public void MakeNoise()
        {
            Console.WriteLine("Kwak, kwak, kwak");
        }
    }
}