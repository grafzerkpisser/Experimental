using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class NewsStation : ISubject
    {
        private readonly List<IObserver> _observers;
        private string _message;

        public NewsStation()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            _message = message;
            foreach (var observer in _observers)
            {
                observer.Update(_message);
            }
        }
    }
}