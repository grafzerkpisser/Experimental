namespace DecoratorPattern
{
    public abstract class Decorator : Beverage
    {
        public abstract override string GetDescription();
    }
}