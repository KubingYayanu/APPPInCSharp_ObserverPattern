namespace APPPInCSharp_ObserverPattern
{
    public interface ClockObserver
    {
        void Update(int hours, int minutes, int secs);
    }
}