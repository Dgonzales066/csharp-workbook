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

            // smallGarage.ParkCar(car1, 0);
            // smallGarage.ParkCar(car2, 1);
            Report rando = new Report();

            Console.WriteLine(smallGarage.Cars);
            Console.WriteLine(rando.Customers);

            Console.WriteLine("hello");
        }
    }
//****************************************************************************** */
    class Car
    {
        private People[] peeps;

        //Constructor - Initializer?
        public Car(string initialColor)
        {
            this.Color = initialColor;
        }

        //1st Property? Field? Object?  
        public string Color { get; set; }

    }

//****************************************************************************** */
    class People
    {  
        //private Car[] cars;

        private string name;

        //Constructor - Initializer?
        public People(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Owner
        {
            get
            {
                return this.name;
            }
        }
        
    }

 //****************************************************************************** */
    class Report
    { 
        private People[] peeps;

        private Car[] cars;

        //Constructor - Initializer?
        public Report(string Car, string People)
        {

        }

        public string Customers
        {
            get 
            {
                for (int i = 0; i < peeps.Length && i < cars.Length; i++)
                {
                    if (peeps[i] != null && cars[i] != null)
                    {
                        Console.WriteLine($"{peeps[i].Name} owns the {cars[i].Color} car.");
                    } 
                }
                return "thats all.";
            }
        }

    }

 
//****************************************************************************** */
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
 
        // public void ParkCar(Car car, int spot)
        // {
        //     cars[spot] = car;
        // }
    }

}
