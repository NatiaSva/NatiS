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
            //exercise4
            Time2 time11 = new Time2(15, 10, 22);
            Time2 time12 = new Time2(time11);
            Time2 time13 = new Time2(14, 10, 22);

            Console.WriteLine(time12.ToString());
            Console.WriteLine(time13.Difference(time11));
            Console.WriteLine(time11.Equals(time12));
            Console.WriteLine(time13.Before(time11));
            Console.WriteLine(time11.After(time13));

            //exercice5
            Console.WriteLine();


            Time3 time21 = new Time3(15, 10, 22);
            Time3 time22 = new Time3(time21);
            Time3 time23 = new Time3(14, 10, 22);

            Console.WriteLine(time22.ToString());
            Console.WriteLine(time23.Difference(time21));
            Console.WriteLine(time21.Equals(time22));
            Console.WriteLine(time23.Before(time21));
            Console.WriteLine(time21.After(time23));







            Console.ReadKey();
        }
    }
}
