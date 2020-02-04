using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_time_exercice3_AnotherWay
{
    class Time
    {
        private int hour, minute, second;

        public Time(int hour, int minute, int second)
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
            SetHour(hour);
            SetMinute(minute);
            SetSecond(second);
        }

        public Time(Time other)
        {
            this.hour = other.hour;
            this.minute = other.minute;
            this.second = other.second;

        }


        public int GetHour()
        {
            return hour;
        }

        public void SetHour(int hour)
        {
            if (hour >= 0 || hour <= 23)
                this.hour = hour;
        }

        public int GetMinute()
        {
            return minute;
        }

        public void SetMinute(int minute)
        {
            if (minute >= 0 || minute <= 59)
                this.minute = minute;
        }

        public int GetSecond()
        {
            return second;
        }

        public void SetSecond(int second)
        {
            if (second >= 0 || second <= 59)
                this.second = second;
        }


        private static string AddZero(int num)
        {
            return (num < 10 ? "0" : "") + num;
        }
        public string ToString()
        {
            return AddZero(hour) + ":" + AddZero(minute) + ":" + AddZero(second);
        }

        private int TotalSeconds()
        {
            return ((hour * 60) + minute) * 60 + second;
        }

        //doesn't support null
        public int Difference(Time other)
        {
            if (this == other)
                return 0;
            return this.TotalSeconds() - other.TotalSeconds();
        }

        public bool Equals(Time other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return this.hour == other.hour && this.minute == other.minute && this.second == other.second; 

        }

        public bool Before(Time other)
        {
            return Difference(other) < 0;
        }

        public bool After(Time other)
        {
            return other.Before(this);
        }



    }
}
