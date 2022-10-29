namespace CoffeeFactory.Factory;

public interface ISelection
{
    public int Value { get; }
}

public class SelectionOne : ISelection
{
    public SelectionOne(int value)
    {
        Value = value;
    }

    public int Value { get; }
}

public class SelectionTwo : ISelection
{
    public SelectionTwo(int value)
    {
        Value = value;
    }

    public int Value { get; }
}

public class SelectionThree : ISelection
{
    public SelectionThree(int value)
    {
        Value = value;
    }

    public int Value { get; }
}
