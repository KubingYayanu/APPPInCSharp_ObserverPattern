namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSource : Subject, TimeSource
    {
        private int itsHours;
        private int itsMinutes;
        private int itsSeconds;

        public int GetHours() => itsHours;

        public int GetMinutes() => itsMinutes;

        public int GetSeconds() => itsSeconds;

        public void SetTime(int hours, int minutes, int secs)
        {
            itsHours = hours;
            itsMinutes = minutes;
            itsSeconds = secs;
            NotifyObservers();
        }
    }
}