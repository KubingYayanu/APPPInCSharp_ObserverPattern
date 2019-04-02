namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSink : ClockObserver
    {
        private int itsHours;
        private int itsMinutes;
        private int itsSeconds;

        public int GetHours() => itsHours;

        public int GetMinutes() => itsMinutes;

        public int GetSeconds() => itsSeconds;

        public void Update(int hours, int minutes, int secs)
        {
            itsHours = hours;
            itsMinutes = minutes;
            itsSeconds = secs;
        }
    }
}