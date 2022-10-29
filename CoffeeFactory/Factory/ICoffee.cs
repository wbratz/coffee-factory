namespace CoffeeFactory.Factory;

public interface ICoffee
{
    public List<string> Ingredients { get; }
}

public class Cappuccino : ICoffee
{
    public List<string> Ingredients { get; }

    public Cappuccino(List<string> ingredients)
    {
        Ingredients = ingredients;
    }
}

public class Espresso : ICoffee
{
    public List<string> Ingredients { get; }

    public Espresso(List<string> ingredients)
    {
        Ingredients = ingredients;
    }
}

public class RegularCoffee : ICoffee
{
    public List<string> Ingredients { get; }

    public RegularCoffee(List<string> ingredients)
    {
        Ingredients = ingredients;
    }
}
