using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_class_exercise56
{
   public class Car1
    {
        private int licensePlateNumber;
        private string color;
        private int km = 0;
        private string manufacturer;
        private string model;
        private bool automaticBrakingSystem;
        static int speed;
        static int counter;
        public Car1(int lp, string cr, int k, string mf, string m, bool ab)
        {
            licensePlateNumber = lp;
            color = cr;
            km = k;
            manufacturer = mf;
            model = m;
            automaticBrakingSystem = ab;
        }
        public Car1()
        { 
        
        }
  

        public int GetLicensePlateNumber()
        {
            return licensePlateNumber;
        }


        public string GetColor()
        {
            return color;
        }


        public int GetKm()
        {
            return km;
        }


        public string GetManufactore()
        {
            return manufacturer;
        }


        public string GetModel()
        {
            return model;
        }


        public bool GetAutomaticBrakingSystem()
        {
            return automaticBrakingSystem;
        }
        public static int MaxKm(Car1[] cars)
        {
            
            speed = int.MinValue;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                    continue;
                if (cars[i].km > speed)
                {
                    speed = cars[i].km;
                    counter=i;
                }
            }
            return counter;
        }


    }
}
