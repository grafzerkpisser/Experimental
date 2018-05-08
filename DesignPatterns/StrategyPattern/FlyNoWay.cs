using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flap flap, I don't have real wings, I can't fly!");
        }
    }
}