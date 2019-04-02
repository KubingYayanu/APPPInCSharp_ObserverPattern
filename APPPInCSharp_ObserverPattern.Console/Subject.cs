using System.Collections.Generic;

namespace APPPInCSharp_ObserverPattern
{
    public class Subject
    {
        private List<Observer> itsObservers = new List<Observer>();

        public void NotifyObservers()
        {
            foreach (var observer in itsObservers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(Observer observer)
        {
            itsObservers.Add(observer);
        }
    }
}