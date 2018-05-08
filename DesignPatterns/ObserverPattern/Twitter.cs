using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class Twitter : IObserver
    {
        private string _message;
        private readonly ISubject _newsStation;

        public Twitter(ISubject newsStation)
        {
            _newsStation = newsStation;
            _newsStation.RegisterObserver(this);
        }
        public void Update(string message)
        {
            _message = message;
            Console.WriteLine($"I am a twitter message and I am presenting you the following message: {_message}");
        }
    }
}