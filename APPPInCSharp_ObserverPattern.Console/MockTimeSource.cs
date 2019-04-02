namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSource : TimeSource
    {
        private TimeSourceImplementation timeSourceImpl = new TimeSourceImplementation();

        public void RegisterObserver(ClockObserver observer)
        {
            timeSourceImpl.RegisterObserver(observer);
        }

        public void SetTime(int hours, int minutes, int secs)
        {
            timeSourceImpl.Notify(hours, minutes, secs);
        }
    }
}