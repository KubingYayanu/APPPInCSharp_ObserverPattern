using NUnit.Framework;

namespace APPPInCSharp_ObserverPattern.UnitTests
{
    [TestFixture]
    public class ClockDriverTests
    {
        private MockTimeSource source;
        private MockTimeSink sink;

        [SetUp]
        public void SetUp()
        {
            source = new MockTimeSource();
            sink = new MockTimeSink(source);
            source.RegisterObserver(sink);
        }

        [Test]
        public void TestTimeChange()
        {
            source.SetTime(3, 4, 5);
            AssertSinkEquals(sink, 3, 4, 5);

            source.SetTime(7, 8, 9);
            AssertSinkEquals(sink, 7, 8, 9);
        }

        [Test]
        public void TestMultipleSinks()
        {
            MockTimeSink sink2 = new MockTimeSink(source);
            source.RegisterObserver(sink2);

            source.SetTime(12, 13, 14);
            AssertSinkEquals(sink, 12, 13, 14);
            AssertSinkEquals(sink2, 12, 13, 14);
        }

        private void AssertSinkEquals(MockTimeSink sink, int hours, int minutes, int secs)
        {
            Assert.AreEqual(hours, sink.GetHours());
            Assert.AreEqual(minutes, sink.GetMinutes());
            Assert.AreEqual(secs, sink.GetSeconds());
        }
    }
}