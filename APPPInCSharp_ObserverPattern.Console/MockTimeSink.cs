namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSink : Observer
    {
        public MockTimeSink(TimeSource source)
        {
            itsSource = source;
        }

        private int itsHours;
        private int itsMinutes;
        private int itsSeconds;
        private TimeSource itsSource;

        public int GetHours() => itsHours;

        public int GetMinutes() => itsMinutes;

        public int GetSeconds() => itsSeconds;

        public void Update()
        {
            itsHours = itsSource.GetHours();
            itsMinutes = itsSource.GetMinutes();
            itsSeconds = itsSource.GetSeconds();
        }
    }
}