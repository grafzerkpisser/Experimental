namespace DecoratorPattern
{
    public class Milk : Decorator
    {
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()} ,Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.2;
        }
    }
}