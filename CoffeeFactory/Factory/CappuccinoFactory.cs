namespace CoffeeFactory.Factory;

internal sealed class CappuccinoFactory : CoffeeFactoryBase
{
    private static readonly List<string> _ingredients = new List<string>
    {
        "Espresso",
        "Foamed Milk"
    };

    public override ICoffee MakeCoffee(bool addPumpkinSpice)
    {
        if (addPumpkinSpice)
        {
            _ingredients.Add("Pumpkin Spice");
        }

        Console.WriteLine($"Brewing your {nameof(Cappuccino)}");

        return new Cappuccino(_ingredients);
    }
}
