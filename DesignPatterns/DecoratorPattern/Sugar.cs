namespace DecoratorPattern
{
    public class Sugar : Decorator
    {
        private readonly Beverage _beverage;

        public Sugar(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()} ,Suggar";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.1;
        }
    }
}