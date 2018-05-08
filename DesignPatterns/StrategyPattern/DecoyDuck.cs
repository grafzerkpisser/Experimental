using System;

namespace StrategyPattern
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
        }
        public override void Display()
        {
            Console.WriteLine("I am a Decoy duck!");
            base.Display();
        }
    }
}