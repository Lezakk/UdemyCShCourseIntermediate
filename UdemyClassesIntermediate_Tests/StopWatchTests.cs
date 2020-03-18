using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UdemyClassesIntermediate;
using System.Threading;

namespace UdemyClassesIntermediate_Tests
{
    [TestFixture]
    class StopWatchTests
    {
        private StopWatch _stopWatch;
        [SetUp]
        public void SetUp()
        {
            _stopWatch = new StopWatch();
        }
        [TestCase(5000)]
        [TestCase(12000)]
        [TestCase(1000)]
        public void Start_WhenStartMethodCalledStartTimerAndWhenStopMethodCalledStopTimer_ReturnsTimeFromStartToEnd(int time)
        {
            _stopWatch.StartStopWatch();
            Thread.Sleep(time); // miliseconds
            var result = _stopWatch.StopStopWatch();
            Assert.That(Math.Round(result.TotalSeconds, 1), Is.EqualTo(TimeSpan.FromMilliseconds(time).TotalSeconds));
        }

        [Test]
        public void Start_WhenStartMethodIsCalledTwiceInTheRow_ThrowException()
        {
            _stopWatch.StartStopWatch();
            Assert.Throws<InvalidOperationException>(() => _stopWatch.StartStopWatch());
        }
    }
}   
