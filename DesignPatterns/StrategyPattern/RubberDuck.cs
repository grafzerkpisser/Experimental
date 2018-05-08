using System;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Squeak());
        }
        public override void Display()
        {
            Console.WriteLine("I am a Rubber duck!");
            base.Display();
        }
    }
}