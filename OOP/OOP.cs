using System;

namespace OOP
{
    class Program
    {
        //Business Logic
        static void Main()
        {
            Garage smallGarage = new Garage(2);
            Car car1 = new Car("red");
            Car car2 = new Car("blue");

            smallGarage.ParkCar(car1, 0);
            smallGarage.ParkCar(car2, 1);

            //Console.WriteLine("howdy");
            //smallGarage.ParkCar(carTwo, 0);
            // Console.WriteLine(Car.Garage.color.Cars());

            Console.WriteLine(smallGarage.Cars);
            // Console.WriteLine(carOne.color);
            // Console.WriteLine(smallGarage.cars[spot]);
            // Console.WriteLine(car1.color);
            // Console.WriteLine(car2.color);
        }
    }

    class Car
    {
        //Constructor - Initializer?
        public Car(string initialColor)
        {
            Color = initialColor;
        }

        //1st Property?
        public string Color { get; private set; }
    }

    class Garage
    {
        private Car[] cars;

        //Constructor
        public Garage(int size)
        {
            Size = size;
            //instantiate the Car with the correct number of spots
            this.cars = new Car[size];
        }

        //Property
        public int Size { get; private set; }

        //Method?
        public string Cars
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if(cars[i] != null)
                    {
                        Console.WriteLine($"The {cars[i].Color} car is in spot1 and the  {cars[i].Color} car in spot 2");
                    }
                }
            }
            return "That's all";
        }

        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;
        }
    }

    class People
    {
        public People()
        {

        }

    }



}
