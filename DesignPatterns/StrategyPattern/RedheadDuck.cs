using System;

namespace StrategyPattern
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quack());
        }
        public override void Display()
        {
            Console.WriteLine("I am a Redhead duck!");
            base.Display();
        }
    }
}