namespace APPPInCSharp_ObserverPattern
{
    public class MockTimeSource : TimeSource
    {
        private ClockDriver itsDriver;

        public void SetTime(int hours, int minutes, int seconds)
        {
            itsDriver.Update(hours, minutes, seconds);
        }

        public void SetDriver(ClockDriver driver)
        {
            itsDriver = driver;
        }
    }
}