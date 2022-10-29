namespace CoffeeFactory.Factory;

internal sealed class RegularCoffeeFactory : CoffeeFactoryBase
{
    private static List<string> _ingredients = new List<string>
    {
        "Coffee Grounds",
        "Water"
    };

    public override ICoffee MakeCoffee(bool addPumpkinSpice)
    {
        if (addPumpkinSpice)
        {
            _ingredients.Add("Pumpkin Spice");
        };

        Console.WriteLine($"Brewing your {nameof(RegularCoffee)}");

        return new RegularCoffee(_ingredients);
    }
}
