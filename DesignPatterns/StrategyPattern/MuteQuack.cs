using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class MuteQuack : IQuackBehavior
    {
        public void MakeNoise()
        {
            Console.WriteLine("I can't make noise!!!");
        }
    }
}