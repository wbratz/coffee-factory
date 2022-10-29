namespace CoffeeFactory.Factory;

internal sealed class EspressoFactory : CoffeeFactoryBase
{
    private static List<string> _ingredients = new List<string>
    {
        "Fine Ground Coffee",
        "Water"
    };

    public override ICoffee MakeCoffee(bool addPumpkinSpice)
    {
        if (addPumpkinSpice)
        {
            _ingredients.Add("Pumpkin Spice");
        }

        Console.WriteLine($"Brewing your {nameof(Espresso)}");

        return new Espresso(_ingredients);
    }
}
