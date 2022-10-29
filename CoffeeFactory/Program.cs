using CoffeeFactory.Factory;

Console.WriteLine("Welcome to the online barista!");
Console.WriteLine("Choose your beverage (1, 2, 3)");
Console.WriteLine("1: Cappuccino");
Console.WriteLine("2: Espresso");
Console.WriteLine("3: Regular Coffee");

var userInput = int.Parse(Console.ReadLine());

Console.WriteLine("It's fall, wanna add pumpkin spice? (Y/N)");

var pumpkinSpice = Console.ReadLine().ToLowerInvariant().Equals("y");

ISelection coffeeSelection = null;

switch (userInput)
{
    case 1:
        coffeeSelection = new SelectionOne(userInput);
        break;
    case 2:
        coffeeSelection = new SelectionTwo(userInput);
        break;
    case 3:
        coffeeSelection = new SelectionThree(userInput);
        break;
}


var customerCoffee = Initilizer.Brew(coffeeSelection, pumpkinSpice);
var pumpkinSpricestring = pumpkinSpice ? string.Empty : "out";
Console.WriteLine($"Your {coffee.GetType().Name} with{pumpkinSpricestring} pumpkin spice is ready!");

