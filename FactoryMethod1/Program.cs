using System;

namespace FactoryMethod1
{
    internal class Program
    {
        private static void Main()
        {
            var selected = false;
            PizzaCreator pizzaCreator = null;

            Console.WriteLine("Введите название пиццы");
            while (selected == false)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Pepperoni":
                        pizzaCreator = new PepperoniCreator();
                        selected = true;
                        break;

                    case "Four Seasons":
                        pizzaCreator = new FourSeasonsCreator();
                        selected = true;
                        break;

                    default:
                        Console.WriteLine("Неверное название пиццы");
                        break;
                }
            }

            var pizza = pizzaCreator.CreatePizza();
            Console.WriteLine(pizza);

            Console.Read();
        }
    }
}