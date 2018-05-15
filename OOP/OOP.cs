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

            People driver1 = new People("Jane");
            People driver2 = new People("Bill");

            smallGarage.ParkCar(car1, 0);
            smallGarage.ParkCar(car2, 1);

            Console.WriteLine(smallGarage.Cars);
            Console.WriteLine("hello");
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
                        Console.WriteLine($"The {cars[i].Color} car is in spot {i + 1}");
                    }
                }
                return "In the samll garage.";
            }
        }

        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;
        }
    }

    class People
    {  
        private Car[] cars;

        private string name;

        public People(string name)
        {
            this.name = name;
        }

        public string Owners
        {
            get
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (cars[i] != null)
                    {
                        Console.WriteLine($"The {cars[i].Color} car is {this.name}");
                    }
                }
                return "small garage";
            }
        }       

    }



}
