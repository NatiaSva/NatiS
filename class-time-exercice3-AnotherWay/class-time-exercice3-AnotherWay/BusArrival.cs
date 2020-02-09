using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_time_exercice3_AnotherWay
{
    //exercise1-  5
    public class BusArrival
    {
        public const int MaxPass = 50;
        private int busNumber;
        private Time time;
        private int numberOfpassengers;
       

        public BusArrival(int busNumber, int hour, int minute, int second, int numberOfpassengers) : this(busNumber, numberOfpassengers)
        {
            Time = new Time(hour, minute, second);
        }

        public BusArrival(int busNumber, Time time, int numberOfpassengers) : this(busNumber, numberOfpassengers)
        {
            Time = new Time(time);
        }

        public BusArrival(BusArrival other) : this(other.busNumber, other.Time, other.NumberOfpassengers) { }

        private BusArrival(int busNumber, int numberOfpassengers)
        {
            this.busNumber = 0;
            this.numberOfpassengers = 0;
            BusNumber = busNumber;
            NumberOfpassengers = numberOfpassengers;
        }

        public int BusNumber
        {
            get
            {
                return busNumber;
            }
            set
            {
                if (value > 99 || value <= 0)
                    return;
                busNumber = value;
            }

        }

        public int NumberOfpassengers
        {
            get
            {
                return numberOfpassengers;
            }
            set
            {
                if (value > 50 || value < 0)
                    return;
                numberOfpassengers = value;
            }
        }

        public Time Time
        {
            get
            {
                return new Time(time);
            }
            set
            {
                time = new Time(value);
            }

        }

        public string ToString()
        {
            return "Bus number- " + BusNumber + "\n" + "Number of passengers- " + NumberOfpassengers + "\n" + Time.ToString();
        }

        public bool Equals(BusArrival other)
        {
            if (other == null)
                return false;
            if (this == other)
                return true;
            return this.BusNumber == other.BusNumber && this.NumberOfpassengers == other.NumberOfpassengers && this.Time.Equals(other.Time);
        }

        public bool Fuller(BusArrival other)
        {
            if (other.NumberOfpassengers > this.NumberOfpassengers)
                return true;
            return false;
        }

        public bool Before(BusArrival other)
        {
            return this.Time.Before(other.Time);
        }


        public static BusArrival EarliestBus(BusArrival[] busArray)
        {
            int tempIndex = 0;
            for (int i = 1; i <busArray.Length; i++)
            {
                if (busArray[i].NumberOfpassengers >= 10 && busArray[i].Time.Before(busArray[tempIndex].Time))
                {
                    tempIndex = i;
                }
            }
            Console.WriteLine("\n"+"The earliest bus is: " +"\n" +busArray[tempIndex].ToString() +"\n" +"\n");
      
            return busArray[tempIndex];
        }


        public bool IsFull()
        {
            if (this.NumberOfpassengers == MaxPass)
                return true;
            return false;
        }

        public int EllapesMinutes(BusArrival other)
        {
            return this.Time.Difference(other.Time) / 60;
        }

    }

}
