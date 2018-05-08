using System;

namespace DecoratorPattern
{

    /// <summary>
    /// Classes should be open for extension but closed for modification
    ///
    /// Decorator pattern - Attach additional responsibilities
    /// to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing
    /// for extending functionality
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Observer pattern \r\n");

            Console.WriteLine("I order a DarkRoast");
            Beverage beverage1 = new DarkRoast();
            TicketUpdate(beverage1);

            Console.WriteLine("I want a double sugar");
            beverage1 = new Sugar(beverage1);
            beverage1 = new Sugar(beverage1);
            TicketUpdate(beverage1);

            Console.WriteLine("And also some booze in it");
            beverage1 = new Whiskey(beverage1);
            TicketUpdate(beverage1);

            Console.ReadLine();
        }

        private static void TicketUpdate(Beverage b)
        {
            Console.WriteLine($"The current ticket shows: Description: {b.GetDescription()} \t \t \t Cost: {b.Cost()} \r\n");
        }

    }
}
