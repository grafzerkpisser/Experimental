using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class Radio : IObserver
    {
        private string _message;
        private readonly ISubject _newsStation;

        public Radio(ISubject newsStation)
        {
            _newsStation = newsStation;
            _newsStation.RegisterObserver(this);
        }
        public void Update(string message)
        {
            _message = message;
            Console.WriteLine($"I am a radio message and I am presenting you the following message: {_message}");
        }
    }
}