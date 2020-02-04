using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_time_exercice3_AnotherWay
{

    //exercice4
    class Time2
    {
        private int totalSeconds;


        public Time2(int hour, int minute, int second)
        {
            SetTotalSeconds(hour, minute, second);
        }

        private void SetTotalSeconds(int hour, int minute, int second)
        {
            totalSeconds = ((hour * 60) + minute) * 60 + second;
        }

        public Time2(Time2 other) 
        {
            this.totalSeconds = other.totalSeconds;
        
        }

        public int GetHour()
        {
            return totalSeconds / 3600;
        }
        public void SetHour(int hour)
        {
            if (hour <= 23 && hour >= 0)
              SetTotalSeconds(hour, GetMinute(), GetSecond());
        }

        public int GetMinute()
        {
            return (totalSeconds % 3600) / 60;
        }
        public void SetMinute(int minute)
        {
            if (minute <= 59 && minute >= 0)
                SetTotalSeconds(GetHour(), minute, GetSecond());
        }
        public int GetSecond()
        {
            return totalSeconds % 60; 
        }
        public void SetSecond(int second)
        {
            if (second <= 59 && second >= 0)
                SetTotalSeconds(GetHour(), GetMinute(), second);
        }

        private static string AddZero(int num)
        {
            return (num < 10 ? "0" : "") + num;
        }
        public string ToString()
        {
            return AddZero(GetHour()) + ":" + AddZero(GetMinute()) + ":" + AddZero(GetSecond());
        }

        public int Difference(Time2 other)
        {
            if (this == other)
                return 0;
            return this.totalSeconds - other.totalSeconds;
        }

        public bool Equals(Time2 other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return this.totalSeconds == other.totalSeconds;
        }

        public bool Before(Time2 other)
        {
            return Difference(other) < 0;
        }

        public bool After(Time2 other)
        {
            return other.Before(this);
        }
    }
}
