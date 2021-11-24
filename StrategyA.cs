namespace StrategyPattern
{
    internal class StrategyA : IStrategy
    {
        public Dto Algorithm() => new("Strategy A", 1);
    }
}
