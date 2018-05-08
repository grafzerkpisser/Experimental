namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        void Update(string message);
    }

    public interface IDisplayElement
    {
        void Display();
    }

    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string message);
    }
}