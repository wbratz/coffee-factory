namespace CoffeeFactory.Factory;

internal sealed class Initilizer
{
    private static readonly Dictionary<int, CoffeeFactoryBase> _factories =
        new Dictionary<int, CoffeeFactoryBase>
            {
            { 1, new CappuccinoFactory() },
            { 2, new EspressoFactory() },
            { 3, new RegularCoffeeFactory() },
            };

    public static ICoffee Brew(ISelection selection, bool addPumpkinSpice)
        => _factories[selection.Value].MakeCoffee(addPumpkinSpice);
}
