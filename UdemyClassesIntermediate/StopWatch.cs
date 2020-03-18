using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesIntermediate
{
    public class StopWatch
    {
        public DateTime Start { get; private set; }
        public DateTime Stop { get; set; }
        public bool Flag { get; set; }
        public StopWatch()
        {
            this.Flag = false; 
        }
        public void StartStopWatch()
        {
            if (this.Flag == true) throw new InvalidOperationException();
            Start = DateTime.Now;
            this.Flag = true;
        }
        public TimeSpan StopStopWatch()
        {
            Stop = DateTime.Now;
            this.Flag = false;
            return Stop - Start;
        }
    }
}
