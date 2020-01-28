using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_time_exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time(15,10,22);
            Time time2 = new Time(time1);
            Time time3 = new Time(14, 10, 22);
            
            Console.WriteLine("The time of object time1 is= {0}",time1.ToSring());
            Console.WriteLine("Is time1 equal to time2= {0}",time1.Equals(time2));
            Console.WriteLine("Is time3 before time1= {0}",time3.Before(time1));
            Console.WriteLine("Is time1 after time3= {0}",time3.After(time1));
            Console.WriteLine("The difference between time1 and time2 in seconds is= {0}",time1.Difference(time3));


            Console.ReadKey();

        }
    }

    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        //constructor
        public Time(int hours, int minutes, int seconds)
        {
            if (hours > 23 || hours < 0)
                hours = 0;
            else
                this.SetHours(hours);
            if (minutes > 59 || minutes < 0)
                minutes = 0;
            else
                this.SetMinutes(minutes);
            if (seconds > 59 || seconds < 0)
                seconds = 0;
            else
                this.SetSeconds(seconds);
        }

        //copy constructor
        public Time(Time other) :this (other.hours, other.minutes , other.seconds)
        { 
        
        }

        //hours
        public int GetHours()
        {
            return hours;
        }

        public void SetHours(int hours)
        {
            if (hours > 23 || hours < 0)
                return;

            this.hours = hours;
        }

        //minutes
        public int GetMinutes()
        {
            return minutes;
        }

        public void SetMinutes(int minutes)
        {
            if (minutes > 59 || minutes < 0)
                return;

            this.minutes = minutes;
        }

        // secondes
        public int GetSeconds()
        {
            return seconds;
        }

        public void SetSeconds(int seconds)
        {
            if (seconds > 59 || seconds < 0)
                return;
            this.seconds = seconds;
          
        }

        public string ToSring()
        {
            string zero = "0";
            string hour = null, minute = null, seconds = null;
            if (this.hours > 9)
                hour = this.hours.ToString();
            else
            hour = zero + this.hours;
            if (this.minutes > 9)
                minute = this.minutes.ToString();
            else
                minute = zero + this.minutes;
            if (this.seconds > 9)
                seconds = this.seconds.ToString();
            else
                seconds = zero + this.seconds;
            return hour + ":" + minute +": "+ seconds;



            /*
            if (this.hours < 9 && this.minutes < 9 && this.seconds < 9)
               return zero + this.hours + " : " + zero + this.minutes + " : " + zero + this.seconds;
            if (this.hours < 9 && this.minutes < 9 && this.seconds > 9)
                return zero + this.hours + " : " + zero + this.minutes + " : " +  this.seconds;
            if (this.hours < 9 && this.minutes > 9 && this.seconds > 9)  
            return zero+this.hours + " : "+this.minutes + " : " +this.seconds;
         return  this.hours + " : " + this.minutes + " : "  + this.seconds;
         */
        }

        public bool Equals(Time other2)
        {
            if (this.hours == other2.GetHours() && this.minutes==other2.GetMinutes() && this.seconds==other2.GetSeconds())
                return true;
            return false;
        }

        public bool Before(Time other)
        {
            bool checkEqual = this.Equals(other);
            if (this.hours > other.GetHours())
                return false;

            if (checkEqual)
                return false;
            
            if ((this.hours == other.GetHours() && this.minutes > other.GetMinutes()) || (this.hours == other.GetHours() && this.minutes == other.GetMinutes() && this.seconds > other.GetSeconds()))
                return false;
            return true;
            
        }

        public bool After(Time other)
        {
            bool before=this.Before(other);
            if (before)
                return true;
            return false;
               
        }

        //The difference in seconds between the object that is received as a parameter and the method applied to it
        public int Difference(Time other)
        {
            int seconds1 = (this.hours * 60 * 60) + (this.minutes * 60) + this.seconds;
            int seconds2 = (other.GetHours() * 60 * 60) + (other.GetMinutes() * 60) + other.GetSeconds();

            if (seconds1 > seconds2)
                return seconds1 - seconds2;
            return seconds2 - seconds1;

        }


    }
}
