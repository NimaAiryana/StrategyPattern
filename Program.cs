using StrategyPattern;

Console.WriteLine("Hello, World!");



var type = Types.StrategyA;

List<Dto> dtos = new();

switch (type)
{
    case Types.StrategyA:
        dtos.Add(new StrategyA().Algorithm());
        break;

    case Types.StrategyB:
        dtos.Add(new StrategyB().Algorithm());
        break;

    default:
        dtos.Add(new StrategyA().Algorithm());
        break;
}

foreach (var dto in dtos) Console.WriteLine($"{nameof(Dto.Value)}: {dto.Value}, {nameof(Dto.IntValue)}: {dto.IntValue}");
