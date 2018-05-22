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

            car1.SeatPeeps(driver1, 0);
            car2.SeatPeeps(driver2, 0);

            smallGarage.ParkCar(car1, 0);
            smallGarage.ParkCar(car2, 1);
            Report rando = new Report(new Garage[] {smallGarage});

            Console.WriteLine(smallGarage.Cars);
            Console.WriteLine(rando.Customers);

            //Console.WriteLine("hello");
        }
    }
//****************************************************************************** */
    class Car
    {
        private People[] peeps = new People[2];

        //Constructor - Initializer?
        public Car(string initialColor)
        {
            this.Color = initialColor;
        }

        //1st Property? Field? Object?  
        public string Color { get; set; }

        public void SeatPeeps(People person, int spot)
        {
            this.peeps[spot] = person;
        }

        public string Peeps 
        { 
            get
            {
                for (int i = 0; i < peeps.Length; i++)
                {
                    if(peeps[i] != null)
                    {
                        Console.WriteLine($"{peeps[i].Name} is in seat number {i + 1}");
                    }
                }
                return " ";
            }
        }

    }

//****************************************************************************** */
    class People
    {  
        //Constructor - Initializer?
        public People(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        
    }

 //****************************************************************************** */
    class Report
    { 
        // private People[] peeps;

        // private Car[] cars;

        private Garage[] garages;

        //Constructor - Initializer?
        public Report(Garage[] garages)
        {
            this.garages = garages;
        }

        public string Customers
        {
            get 
            {
                for (int i = 0; i < this.garages.Length; i++)
                {
                    if (garages[i] != null)
                    {
                        foreach(var car in garages[i].cars)
                        {
                            Console.WriteLine($"The {car.Color} car belongs to the person in seat {i + 1}.");
                            Console.WriteLine("");
                            Console.WriteLine(car.Peeps);
                        }
                    } 
                }
                Console.WriteLine("In the small garage.");
                return "";
            }
        }

    }

 
//****************************************************************************** */
    class Garage
    {
        public Car[] cars;

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
                        Console.WriteLine("");
                        Console.WriteLine($"The {cars[i].Color} car is in spot {i + 1}");
                    }
                }
                return "";
            }
        }
 
        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;
        }
    }

}
