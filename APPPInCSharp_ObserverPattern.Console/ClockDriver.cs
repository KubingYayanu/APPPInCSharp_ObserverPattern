namespace APPPInCSharp_ObserverPattern
{
    public class ClockDriver
    {
        public ClockDriver(TimeSource source, TimeSink sink)
        {
            source.SetDriver(this);
            this.sink = sink;
        }

        private readonly TimeSink sink;

        public void Update(int hours, int minutes, int seconds)
        {
            sink.SetTime(hours, minutes, seconds);
        }
    }
}