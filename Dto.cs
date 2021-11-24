namespace StrategyPattern
{
    internal class Dto
    {
        public Dto(string value, int intValue)
        {
            Value = value;
            IntValue = intValue;
        }

        public string Value { get; set; }
        public int IntValue { get; set; }
    }
}
