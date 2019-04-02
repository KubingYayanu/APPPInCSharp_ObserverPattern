namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSource : TimeSource
    {
        private ClockObserver itsObserver;

        public void SetTime(int hours, int minutes, int seconds)
        {
            itsObserver.Update(hours, minutes, seconds);
        }

        public void SetObserver(ClockObserver observer)
        {
            itsObserver = observer;
        }
    }
}