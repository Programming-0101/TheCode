using System;
using System.Linq;

namespace Topic.E.Examples
{
    public class ElapsedTime
    {
        public ElapsedTime(int hours, int minutes, int seconds)
        {
            TotalSeconds = hours * 60 * 60;
            TotalSeconds += minutes * 60;
            TotalSeconds += seconds;

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public ElapsedTime(int totalSeconds)
        {
            Hours = totalSeconds / (60 * 60);
            Minutes = (totalSeconds - Hours * 60 * 60) / 60;
            Seconds = totalSeconds - Hours * 60 * 60 - Minutes * 60;

            TotalSeconds = totalSeconds;
        }

        public int Hours { get; private set; }

        public int Minutes { get; private set; }

        public int Seconds { get; private set; }

        public int TotalSeconds { get; private set; }
    }
}
