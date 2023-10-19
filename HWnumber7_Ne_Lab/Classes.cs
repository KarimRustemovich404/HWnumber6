using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber6_Ne_Lab
{
     class ClassHouse
    {
        private double HouseNumber;
        private double HouseHeight;
        private double HouseFloors;
        private double HouseParadnie;
    }

     class BakeryKithcen
    {


        public string Name;
        public string BestDesert;
        public string WorstDesert;
        public string BestManager;
        public double AmountOfDishes;
    }
      class BakeryFoodArea : BakeryKithcen
    {
        public double AdorbaleCustomres;
        public double DisgustingCustomers;

    }
      class BakeriesLogistic
    {
        public double AmountOfDrivers;
        public double AmountOfDrunkDrivers;
        public double AmoutOfPlacesToDeliver;
    }
    abstract class Transport : BakeriesLogistic
    {
        public void Move()
        {
            Console.WriteLine("Транспорт находится в движении. Водитель может быть пьяным");
        }
    }
    class Car : Transport { }
    class DamnEscooter : Transport { }
    class Legs : Transport { }

    
    

}
