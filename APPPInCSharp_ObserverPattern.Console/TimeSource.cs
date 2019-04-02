namespace APPPInCSharp_ObserverPattern
{
    public interface TimeSource
    {
        void RegisterObserver(ClockObserver driver);
    }
}