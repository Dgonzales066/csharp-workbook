using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Car
    {
        public Car(string initialColor)
        {
             color = initialColor;
        }

        public string color { get; set; }
        
    }

    class Garage
    {
        private Car[] cars;

        public Garage(int size)
        {
            Size = size;
            this.cars = new Car[size];
        }

        public int Size { get; private set; }

        public string Cars
        {
            get
            {
                return $"Car in spot 0 is {cars[0].color}";
            }
        }
    }



}
