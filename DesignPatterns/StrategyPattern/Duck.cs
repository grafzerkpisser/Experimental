using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        public virtual void Display()
        {

        }

        public void SetQuackBehavior(IQuackBehavior behavior)
        {
            _quackBehavior = behavior;
        }

        public void SetFlyBehavior(IFlyBehavior behavior)
        {
            _flyBehavior = behavior;
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.MakeNoise();
        }
    }
}