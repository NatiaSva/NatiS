using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_class_exercise56
{
    class Program
    {
        static void Main(string[] args)
        {
            Car1 car1 = new Car1(123456, "black", 1000,"bmw","x3",true);
            Car1 car2 = new Car1(123456, "black", 1000, "bmw", "x3", true);
            Car1 car3 = new Car1(789566, "white",2000, "shevrolet", "cavalier",false);
            Car1 car4 = new Car1();
            car4 = car3;
            Car1 car5 = new Car1();
            car5 = null;
            Car1 car6 = new Car1(8888,"red",55,"bugatti","chiron",true);

            Car1[] cars = {car1,car2,car3,car4,car5,car6};
            PrintCardetails(cars);
            PringMaxKm(cars);


            Console.ReadKey();
        }

        public static void PrintCardetails(Car1[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                    continue;

                Console.WriteLine("The car details are: ");
                Console.WriteLine("licensePlateNumber={0}", cars[i].GetLicensePlateNumber());
                Console.WriteLine("color={0}", cars[i].GetColor());
                Console.WriteLine("km={0}", cars[i].GetKm());
                Console.WriteLine("manufacture={0}", cars[i].GetManufactore());
                Console.WriteLine("model={0}", cars[i].GetManufactore());
                Console.WriteLine("automaticBrakingSystem={0}", cars[i].GetAutomaticBrakingSystem());
                Console.WriteLine();
                Console.WriteLine();
            }
        
        }

        public static void PringMaxKm(Car1[] cars)
        {
            Console.WriteLine("PringMaxKm: ");
            int counter = Car1.MaxKm(cars);
            Console.WriteLine("licensePlateNumber={0}", cars[counter].GetLicensePlateNumber());
            Console.WriteLine("color={0}", cars[counter].GetColor());
            Console.WriteLine("km={0}", cars[counter].GetKm());
            Console.WriteLine("manufacture={0}", cars[counter].GetManufactore());
            Console.WriteLine("model={0}", cars[counter].GetManufactore());
            Console.WriteLine("automaticBrakingSystem={0}", cars[counter].GetAutomaticBrakingSystem());
        }

    

    
    }
}
