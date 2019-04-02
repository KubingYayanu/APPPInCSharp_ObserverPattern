namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSource : TimeSource
    {
        public void SetTime(int hours, int minutes, int secs)
        {
            Notify(hours, minutes, secs);
        }
    }
}