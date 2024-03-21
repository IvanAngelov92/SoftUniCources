using System;
using System.Collections.Generic;
using System.Linq;

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

    public Car(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
}

class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }

    public void AddCar(string brand, string model, int horsePower)
    {
        Cars.Add(new Car(brand, model, horsePower));
    }

    public void AddTruck(string brand, string model, int weight)
    {
        Trucks.Add(new Truck(brand, model, weight));
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Cars:");
        foreach (var car in Cars.OrderBy(c => c.Brand))
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
        }

        Console.WriteLine("Trucks:");
        foreach (var truck in Trucks.OrderBy(t => t.Brand))
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] vehicleInfo = input.Split('/');
            string type = vehicleInfo[0];
            string brand = vehicleInfo[1];
            string model = vehicleInfo[2];
            int value = int.Parse(vehicleInfo[3]);

            if (type == "Car")
            {
                catalog.AddCar(brand, model, value);
            }
            else if (type == "Truck")
            {
                catalog.AddTruck(brand, model, value);
            }
        }

        catalog.PrintCatalog();
    }
}