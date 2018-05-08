using System.Threading;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string Description = "unknown";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}