using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLibrary
{
    public class Time3
    {
        private int hour; // 0-23
        private int minute; // 0-59
        private int second; // 0-59

        // Time3 constructor initializes instance variables to
        // zero to set default time to midnight
        public Time3()
        {
            SetTime(0, 0, 0);
        }

        // Time3 constructor: hour supplied, minute and second
        // defaulted to 0
        public Time3(int hour)
        {
            SetTime(hour, 0, 0);
        }

        // Time3 constructor: hour and minute supplied, second
        // defaulted to 0
        public Time3(int hour, int minute)
        {
            SetTime(hour, minute, 0);
        }

        // Time3 constructor: hour, minute and second supplied
        public Time3(int hour, int minute, int second)
        {
            SetTime(hour, minute, second);
        }


        // Time3 constructor: initialize using another Time3 object
        public Time3(Time3 time)
        {
            SetTime(time.Hour, time.Minute, time.Second);
        }

        // Set new time value in 24-hour format. Perform validity
        // checks on the data. Set invalid values to zero.
        public void SetTime(
        int hourValue, int minuteValue, int secondValue)
        {
            Hour = hourValue;
            Minute = minuteValue;
            Second = secondValue;
        }

        // property Hour
        public int Hour
        {
            get
            {
                return hour;
            }

            set
            {
                hour = ((value >= 0 && value < 24) ? value : 0);
            }

        } // end property Hour

        // property Minute
        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                minute = ((value >= 0 && value < 60) ? value : 0);
            }

        } // end property Minute

        // property Second
        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                second = ((value >= 0 && value < 60) ? value : 0);
            }

        } // end property Second

        // convert time to universal-time (24 hour) format string
        public string ToUniversalString()
        {
            return String.Format(
            "{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
        }

        // convert time to standard-time (12 hour) format string
        public string ToStandardString()
        {
            return String.Format("{0}:{1:D2}:{2:D2} {3}",
            ((Hour == 12 || Hour == 0) ? 12 : Hour % 12),
            Minute, Second, (Hour < 12 ? "AM" : "PM"));
        }
    }
}
