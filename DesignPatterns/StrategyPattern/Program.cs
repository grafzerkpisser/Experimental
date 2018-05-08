using System;
using System.Collections.Generic;

namespace StrategyPattern
{

    /// <summary>
    /// Strategy Pattern
    ///
    /// Isolate what changes
    /// Perfer composition above inheritance
    /// Program to an interface, not to an implementation
    ///
    ///
    /// The strategy pattern defines a family of algorithms,
    /// encapsulates each one, and make them interchangeable.
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Strategy pattern  \r\n");
            var ducks = new List<Duck>()
            {
                new DecoyDuck(),
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();

                if (duck.GetType() == typeof(DecoyDuck))
                {
                    Console.WriteLine("Changing the behavior at runtime");
                    duck.SetFlyBehavior(new FlyWithWings());
                    duck.SetQuackBehavior(new Quack());
                    duck.PerformFly();
                    duck.PerformQuack();
                }
                Console.WriteLine("--------------------");
            }

            Console.ReadLine();

        }
    }
}
