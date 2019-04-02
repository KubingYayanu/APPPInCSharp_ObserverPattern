namespace APPPInCSharp_ObserverPattern
{
    public interface TimeSource
    {
        void SetObserver(ClockObserver driver);
    }
}