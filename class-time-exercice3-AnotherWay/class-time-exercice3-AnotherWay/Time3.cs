using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_time_exercice3_AnotherWay
{
    //exercise 5
    class Time3
    {
        private int totalSeconds;


        public Time3(int hour, int minute, int second)
        {
            SetTotalSeconds(hour, minute, second);
        }

        private void SetTotalSeconds(int hour, int minute, int second)
        {
            totalSeconds = ((hour * 60) + minute) * 60 + second;
        }

        public Time3(Time3 other)
        {
            this.totalSeconds = other.totalSeconds;
        }

        public int Hour
        {
            get
            {
                return totalSeconds / 3600;
            }
            set
            {
               
                if (value <= 23 && value >= 0)
                    SetTotalSeconds(value, Minute, Second);
            }
        }

        public int Minute
        {
            get
           {
                return (totalSeconds % 3600) / 60;
           }
            set
            {
                if ( value <= 59 && value >= 0)
                    SetTotalSeconds(Hour, value, Second);
            }
        }
        public int Second
        {
            get
            {
                return totalSeconds % 60;
            }
            set
            {
                if (value <= 59 && value >= 0)
                    SetTotalSeconds(Hour, Minute, value);
            }
        }

        private static string AddZero(int num)
        {
            return (num < 10 ? "0" : "") + num;
        }
        public string ToString()
        {
            return AddZero(Hour) + ":" + AddZero(Minute) + ":" + AddZero(Second);
        }

        public int Difference(Time3 other)
        {
            if (this == other)
                return 0;
            return this.totalSeconds - other.totalSeconds;
        }

        public bool Equals(Time3 other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return this.totalSeconds == other.totalSeconds;
        }

        public bool Before(Time3 other)
        {
            return Difference(other) < 0;
        }

        public bool After(Time3 other)
        {
            return other.Before(this);
        }

    }
}
