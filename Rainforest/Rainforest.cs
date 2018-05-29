using System;
using System.Collections.Generic;

namespace RainForest 
{
    class Program {
        static void Main (string[] args) {
            Company rainforest = new Company ("Rainforest, LLC");

            string[] cities = new string[] { "Austin", "Houston", "Dallas", "San Antonio" };
            string[] items = new string[] { "Banana", "Toothpaste", "Baseball", "Laptop" };

            foreach (var city in cities) {
                rainforest.warehouses.Add (new Warehouse (city, 1));
                rainforest.warehouses.Add (new Warehouse (city, 2));
            }

            for (int i = 0; i < rainforest.warehouses.Count; i++) 
            {
                Warehouse warehouse = rainforest.warehouses[i];
                Container container = new Container ($"{warehouse.location}-1", i + 1);
                rainforest.warehouses[i].containers.Add (container);
            }

            for (int i = 0; i < 4; i++) {
                Container container = rainforest.warehouses[i].containers[0];
                Item item = new Item (items[i], i);
                container.items.Add (item);
            }

            rainforest.GenerateManifest ();


            Console.WriteLine ("Hello World!");
            //Console.WriteLine(rainforest.warehouses);
        }
    }



    class Company 
    {
        // Properties
        public string name;

        public List<Warehouse> warehouses;

        // Constructor
        public Company (string name) 
        {
            this.name = name;
            this.warehouses = new List<Warehouse> ();
        }

        public void GenerateManifest () 
        {
            string html = @"
                <html>
                    <head>
                      <style>
                        .company, .warehouse, .container, .item {
                            padding: 20px;
                            display: flex;
                            margin: 10px;
                            flex-wrap: wrap;
                        }
                        .warehouse {
                            background-color: lightsteelblue;
                        }
                        .container {
                            background-color: lightgreen;
                        }
                        .item {
                            background-color: lightpink;
                        }
                      </style>
                    </head>
                    <body>
            ";
            html += String.Format (@"
                <h1>{0}</h1>
                <div class='company'>
            ", this.name);

            foreach (var warehouse in this.warehouses) {
                html += String.Format ("<div class=\"warehouse\">{0}", warehouse.location);
                foreach (var container in warehouse.containers) {
                    html += String.Format ("<div class=\"container\">{0}", container.id);
                    foreach (var item in container.items) {
                        html += String.Format ("<div class=\"item\">{0}</div>", item.name);
                    }
                    html += "</div>";
                }
                html += "</div>";
            }
            html += "</div>";
            html += "</html>";

            System.IO.File.WriteAllText (@"./index.html", html);
        }
    }

    class Warehouse 
    {
        // Properties
        public string location;

        // Properties
        public int size;
        
        public List<Container> containers;

        // Constructor
        public Warehouse (string location, int size) 
        {
            this.location = location;
            this.size = size;
            this.containers = new List<Container> ();
        }

    }

    class Container {
        public List<Item> items;
        public int size;
        public string id;

        // Constructor
        public Container (string id, int size) {
            this.id = id;
            this.size = size;
            this.items = new List<Item> ();
        }

    }

    class Item 
    {
        public string name;
        public double price;

        // Constructor
        public Item (string name, double price) {
            this.name = name;
            this.price = price;
        }

    }

}// end of Rainforest



// Eggs
// Soap bars
// Plain aspirin
// Squirty soap
// Washing tablets
// Dishwasher tablets
// Mouthwash
// Tissues box
// Tissues packet
// Rosemary (dried)
// Olive oil
// Cheese
// Pepper
// Dishwasher salt
// Cheese Biscuits
// Yoghurts
// Margarine
// Freezer bags
// Beans
// Milk
// Washing tablets
// Kitchen towel
// Gravy granules
// Assorted beans
// Onion
// Carrots
// Chicken
// Small tin of salmon
// Crisps
// Weetabix
// Decaf coffee grounds
// Non alcoholic beer
// Milk
// Beer
// Margarine
// Cheese
// Salt
// Bread