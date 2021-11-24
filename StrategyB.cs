namespace StrategyPattern
{
    internal class StrategyB : IStrategy
    {
        public Dto Algorithm() => new("Strategy B", 2);

    }
}
