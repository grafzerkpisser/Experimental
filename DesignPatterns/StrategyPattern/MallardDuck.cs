using System;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quack());
        }
        public override void Display()
        {
            Console.WriteLine("I am a Mallard duck!");
            base.Display();
        }
    }
}