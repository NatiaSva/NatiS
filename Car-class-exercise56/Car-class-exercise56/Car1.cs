using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_class_exercise56
{
   public class Car1
    {
        public int licensePlateNumber;
        public string color;
        public int km = 0;
        public string manufacturer;
        public string model;
        public bool automaticBrakingSystem;


        public void PrintCardetails()
        {
            Console.WriteLine("The car details are: ");
            Console.WriteLine("licensePlateNumber={0} , color={1} ,km={2} ,manufacturer={3} ,model={4}  ,automaticBrakingSystem={5}",
                licensePlateNumber,color ,km, manufacturer,model, automaticBrakingSystem);
        }

        public int GetKM()
        {
            return km;
        }

        public void MaxKm(Car1[] cars)
        {
            int max = 0, count = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                    continue;

                if (cars[i].GetKM() > max)
                {
                    max = cars[i].km;
                    count++;
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("max km:  ");
            cars[count].PrintCardetails();
        }

    }
}
