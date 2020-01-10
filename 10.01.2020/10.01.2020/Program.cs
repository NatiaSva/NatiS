using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 54
            Point a, b;
            a.x = 10;
            b.x = 5;
            a.y = 20;
            b.y = 15;
            Console.WriteLine("GetDistance={0}",GetDistance(a, b));


            Console.ReadKey();
        }

        static int Sqrt(int x)
        {
            int result = 0;
            while (result * result < x)
            {
                result++;
            }
            return result;
        }

        //Exercise 54
        static double GetDistance(Point a,Point b)
        {
            double distance;
            distance = Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
            return distance;
        }
    }

    //Exercise 54
    struct Point
    {
        public int x, y;
    }
}
