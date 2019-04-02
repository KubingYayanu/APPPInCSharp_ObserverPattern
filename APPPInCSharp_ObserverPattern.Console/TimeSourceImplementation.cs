using System.Collections.Generic;

namespace APPPInCSharp_ObserverPattern
{
    public class TimeSourceImplementation : TimeSource
    {
        private List<ClockObserver> itsObservers = new List<ClockObserver>();

        public void Notify(int hours, int minutes, int seconds)
        {
            foreach (var observer in itsObservers)
            {
                observer.Update(hours, minutes, seconds);
            }
        }

        public void RegisterObserver(ClockObserver observer)
        {
            itsObservers.Add(observer);
        }
    }
}