using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flap Flap, I believe I can fly!");
        }
    }
}