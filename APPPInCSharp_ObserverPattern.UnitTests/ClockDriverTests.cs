using NUnit.Framework;

namespace APPPInCSharp_ObserverPattern.UnitTests
{
    [TestFixture]
    public class ClockDriverTests
    {
        [Test]
        public void TestClockDriver()
        {
            MockTimeSource source = new MockTimeSource();
            MockTimeSink sink = new MockTimeSink();
            ClockDriver driver = new ClockDriver(source, sink);
            source.SetTime(3, 4, 5);

            Assert.AreEqual(3, sink.GetHours());
            Assert.AreEqual(4, sink.GetMinutes());
            Assert.AreEqual(5, sink.GetSeconds());

            source.SetTime(7, 8, 9);
            Assert.AreEqual(7, sink.GetHours());
            Assert.AreEqual(8, sink.GetMinutes());
            Assert.AreEqual(9, sink.GetSeconds());
        }
    }
}