using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesIntermediate
{
    public class StopWatch
    {
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public void StartStopWatch()
        {
            Start = DateTime.Now;
        }
        public TimeSpan StopStopWatch()
        {
            Stop = DateTime.Now;
            return Stop - Start;
        }
    }
}
