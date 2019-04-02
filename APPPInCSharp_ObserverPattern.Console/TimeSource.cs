namespace APPPInCSharp_ObserverPattern
{
    public interface TimeSource
    {
        int GetHours();

        int GetMinutes();

        int GetSeconds();
    }
}