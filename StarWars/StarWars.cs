using System;

namespace StarWars
{
    class Program
    {
        static void Main()
        {
            Person leia = new Person("Leia", "Organa", "Rebel");
            Person han = new Person("Han", "Solo", "Rebel");
            Person luke = new Person("Luke", "Skywalker", "Rebel");
            Person darth = new Person("Darth", "Vader", "Imperial");
            Person trooper = new Person("Stormtrooper", "FN2187", "Imperial");
            Person palpatine = new Person("Emporer", "Palpatine", "Imperial");

            Ship xwing = new Ship("X-Wing", "Rebel", "Fighter", 1);
            Ship falcon = new Ship("Millenium Falcon", "Rebel", "Smuggling", 2);
            Ship tie = new Ship("Tie Fighter", "Imperial", "Fighter", 1);
            Ship tiex1 = new Ship("Advance Tie Fighter X1", "Imperial", "Fighter", 1);
            Ship shuttle = new Ship("Shuttle Craft Tydirium", "Imperial", "Landing Craft", 1);

            Station DeathStar = new Station("Death Star", "Imperial", 3);
            Station RebelStation = new Station("Rebel Space Station", "Rebel", 2);

            xwing.EnterShip(luke, 0);
            tie.EnterShip(trooper, 0);
            tiex1.EnterShip(darth, 0);
            falcon.EnterShip(han, 0);
            falcon.EnterShip(leia, 1);
            shuttle.EnterShip(palpatine, 0);

            DeathStar.EnterStation(tie, 0);
            DeathStar.EnterStation(tiex1, 1);
            DeathStar.EnterStation(shuttle, 2);
            RebelStation.EnterStation(falcon, 0);
            RebelStation.EnterStation(xwing, 1);

            Console.WriteLine("");
            Console.WriteLine("Ships and Passengers on Rebel Station: Yavin.");
            RebelStation.Report();
            Console.WriteLine("Ships and Passengers on the Death Star.");
            DeathStar.Report();

            //Console.WriteLine("hello world");
        }
    }
//************************************************************************************** */
    class Person
    {
        private string firstName;

        private string lastName;

        private string alliance;

        public Person(string firstName, string lastName, string alliance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }

            set
            {
                string[] names = value.Split(' ');
                this.firstName = names[0];
                this.lastName = names[1];
            }
        }
    }

//***************************************************************************************/
    class Ship
    {
        private Person[] passengers;

        public Ship(string name, string alliance, string type, int seat)
        {
            this.Name = name;
            this.Alliance = alliance;
            this.Type = type;
            this.passengers = new Person[seat];
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Alliance { get; set; }

        public void EnterShip(Person person, int seat)
        {
            this.passengers[seat] = person;
        }

        // public string Passengers
        // {
        //     get
        //     {
        //         for (int i = 0; i < passengers.Length; i++)
        //         {
        //             if (passengers[i] != null)
        //             {
        //                 Console.WriteLine($"{passengers[i].FullName} is in seat {i + 1}");
        //             }
        //         }
        //         return " ";
        //     }
        // }

        public string Passengers
        {
            get
            {
                foreach (var person in passengers)
                {
                    Console.WriteLine(String.Format("{0}", person.FullName));
                }
                return " ";
            }
        }

        public void ExitShip(int seat)
        {
            this.passengers[seat] = null;
        }
    }

//***************************************************************************************/
     class Station
    {
        private Ship[] ships;

        public Station(string name, string alliance, int spaces)
        {
            this.Name = name;
            this.Alliance = alliance;
            this.ships = new Ship[spaces];
        }

        public string Name { get; set; }

        public string Alliance { get; set; }

        public void EnterStation(Ship ship, int spaces)
        {
            this.ships[spaces] = ship;
        }

        public void Report()
        {
            foreach (Ship ship in ships)
            {
                Console.WriteLine("Ship: ");
                Console.WriteLine(ship.Name);
                Console.WriteLine("Passengers: ");
                Console.WriteLine(ship.Passengers);
            }
        }

        public void ExitStation(Ship ship, int space)
        {
            this.ships[space] = null;
        }

    }


}//end of Star Wars
