namespace DecoratorPattern
{
    public class Whiskey : Decorator
    {
        private readonly Beverage _beverage;

        public Whiskey(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()} ,Whiskey";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 2.0;
        }
    }
}