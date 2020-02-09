using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_time_exercice3_AnotherWay
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercice3
            Time time1 = new Time(15, 10, 22);
            Time time2 = new Time(time1);
            Time time3 = new Time(14, 10, 22);

            Console.WriteLine(time2.ToString());
            Console.WriteLine(time3.Difference(time1));
            Console.WriteLine(time1.Equals(time2));
            Console.WriteLine(time3.Before(time1));
            Console.WriteLine(time1.After(time3));

            Console.WriteLine();


            //exercise1-  5
            BusArrival busArrival1 = new BusArrival(60,14,10,22,5);
            BusArrival busArrival2 = new BusArrival(61,time1,6);
            BusArrival busArrival3 = new BusArrival(busArrival2);
            BusArrival busArrival4 = new BusArrival(60,13,10,22,10);
            BusArrival busArrival5 = new BusArrival(60, 13, 10, 22, 50);
            
            BusArrival[] busArray = {busArrival1,busArrival2,busArrival4};
           
         

            Console.WriteLine(busArrival3.ToString());
            Console.WriteLine("Equals= {0}", busArrival2.Equals(busArrival2));
            Console.WriteLine("Fuller= {0}",busArrival1.Fuller(busArrival2));
            Console.WriteLine("Before= {0}", busArrival2.Before(busArrival1));
            BusArrival.EarliestBus(busArray);
            Console.WriteLine("Number of passengers is 50= {0}",busArrival5.IsFull());
            Console.WriteLine("EllapesMinutes= {0}",busArrival2.EllapesMinutes(busArrival1));

            ////exercise4
            //Time2 time11 = new Time2(15, 10, 22);
            //Time2 time12 = new Time2(time11);
            //Time2 time13 = new Time2(14, 10, 22);

            //Console.WriteLine(time12.ToString());
            //Console.WriteLine(time13.Difference(time11));
            //Console.WriteLine(time11.Equals(time12));
            //Console.WriteLine(time13.Before(time11));
            //Console.WriteLine(time11.After(time13));

            ////exercice2- 5
            //Console.WriteLine();


            //Time3 time21 = new Time3(15, 10, 22);
            //Time3 time22 = new Time3(time21);
            //Time3 time23 = new Time3(14, 10, 22);

            //Console.WriteLine(time22.ToString());
            //Console.WriteLine(time23.Difference(time21));
            //Console.WriteLine(time21.Equals(time22));
            //Console.WriteLine(time23.Before(time21));
            //Console.WriteLine(time21.After(time23));







            Console.ReadKey();
        }
    }
}
