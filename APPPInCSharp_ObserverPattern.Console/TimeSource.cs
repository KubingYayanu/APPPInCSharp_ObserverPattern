namespace APPPInCSharp_ObserverPattern
{
    public interface TimeSource
    {
        void SetDriver(ClockDriver driver);
    }
}