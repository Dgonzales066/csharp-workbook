using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Garage smallGarage = new Garage(2);
            Car redCar = new Car("red");
            Car blueCar = new Car("blue");

            //smallGarage.ParkCar(carTwo, 0);
            // Console.WriteLine(Car.Garage.color.Cars());

            Console.WriteLine(smallGarage.Cars);
            // Console.WriteLine(carOne.color);
            // Console.WriteLine(smallGarage.cars[spot]);
        }
    }

    class Car
    {
        //Constructor - Initializer?
        public Car(string initialColor)
        {
             color = initialColor;
        }

        //1st Property?
        public string color { get; }
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
                return "Car in spot 1 is {cars[0].color} and the Car in spot 2 is {cars[1].color}";
            }
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
