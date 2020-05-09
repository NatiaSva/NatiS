using System;
using System.Collections.Generic;
using System.Threading;

namespace Exercise_32
{
    class Program
    {
        public static List<int> arr = new List<int>();
        public static bool isFound = false;
        static void Main(string[] args)
        {

            //Exercise 32
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(6);
            arr.Add(8);
            Thread thread1 = new Thread(FindValue1);
            Thread thread2 = new Thread(FindValue2);
            thread1.Start(6);
            thread2.Start(6);


            Console.ReadKey();
        }

        //Exercise 32
        static void FindValue1(Object value)
        {

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(i + " -first");
                Thread.Sleep(2000);
                if (isFound)
                    break;
                if (arr[i].Equals(value))
                {
                    isFound = true;
                    Console.WriteLine("found1");
                    break;
                }
            }
        }

        //Exercise 32
        static void FindValue2(Object value)
        {
            for (int i = arr.Count - 1; i > 0; i--)
            {
                if (isFound)
                    break;
                Console.WriteLine(i + " -second");
                Thread.Sleep(1000);
                if (arr[i].Equals(value))
                {
                    isFound = true;
                    Console.WriteLine("found2");
                    break;
                }
            }
        }
    }
}
