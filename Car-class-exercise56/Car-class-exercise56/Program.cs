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
            Car1 car1 = new Car1();
            Car1 car2 = new Car1();
            Car1 car3 = new Car1();
            Car1 car4 = new Car1();
           
            Car1 car5 = new Car1();
            Car1 car6 = new Car1();

            car1.licensePlateNumber = 123456;
            car1.color = "black";
            car1.km = 1000;
            car1.manufacturer = "bmw";
            car1.model="x3";
            car1.automaticBrakingSystem = true;

            car2.licensePlateNumber = 123456;
            car2.color = "black";
            car2.km = 1000;
            car2.manufacturer = "bmw";
            car2.model = "x3";
            car2.automaticBrakingSystem = true;

            car3.licensePlateNumber = 789566;
            car3.color = "white";
            car3.km = 2000;
            car3.manufacturer = "shevrolet";
            car3.model = "cavalier";
            car3.automaticBrakingSystem = false;

            car4 = car3;
            
            car5 = null;
            
            car6.licensePlateNumber = 88888;
            car6.color = "red";
            car6.km = 55;
            car6.manufacturer = "bugati";
            car6.model = "chiron";
            car6.automaticBrakingSystem = true;


            Car1[] cars = {car1,car2,car3,car4,car5,car6};
            int j = 1;
            for (int i = 0; i < cars.Length; i++)
            {
             
                Console.Write(j+")");
                j++;
                if (cars[i] == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("this car doesn't have detail");
                    Console.WriteLine();
                    continue;
                }
                cars[i].PrintCardetails();
             
            }

            for (int i = 0; i <cars.Length; i++)
            {
                if (cars[i] == null)
                    continue;
                cars[i].MaxKm(cars);
                break;
            }
       


            Console.ReadKey();
        }
    }
}
