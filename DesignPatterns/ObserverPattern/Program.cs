using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    class Program
    {
        ///  <summary>
        ///  Observer pattern
        /// 
        ///  Strive for loosely coupled designs between objects that interact
        /// 
        ///  Observer pattern defines a one-to-many dependency between objects
        ///  so that when one object changes state, all its dependents are notified
        ///  and updated automatically.
        ///  </summary>
        static void Main()
        {
            Console.WriteLine("Observer pattern \r\n");
            ISubject newsPaper = new NewsStation();

            Console.WriteLine("Website observer has subscribed to the newspaper");
            var website = new Website(newsPaper);
            Console.WriteLine("NewsPaper writes a message");
            newsPaper.NotifyObservers("Great news, website subscribed to our newspaper!!");
            Console.WriteLine();

            Console.WriteLine("Twitter and radio also subscribe to the newspaper");
            var twitter = new Twitter(newsPaper);
            new Radio(newsPaper);

            Console.WriteLine("NewsPaper writes a new message");
            newsPaper.NotifyObservers("we are getting popular, twitter and radio also subscribed to our newspaper");

            Console.WriteLine();
            Console.WriteLine("But twitter doesn't like the spamming and unsubscribes");
            newsPaper.RemoveObserver(twitter);
            Console.WriteLine("NewsPaper writes a new message. Be aware that twitter doesn't receive the message");
            newsPaper.NotifyObservers("Blablabla");
            Console.ReadLine();
        }

    }
}
