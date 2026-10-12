using System;
namespace VehicleHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "grande", 2025, 4);
            myCar.DisplayInfo();
            Console.WriteLine();
            Motorbike myBike = new Motorbike("Yamaha", "R1", 2024, false);
            myBike.DisplayInfo();
            Console.ReadLine();
        }
    }
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Brand} {Model}");
        }
    }
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, int numberOfDoors)
            : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Car | Doors: {NumberOfDoors}");
        }
    }
    public class Motorbike : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorbike(string brand, string model, int year, bool hasSidecar)
            : base(brand, model, year)
        {
            HasSidecar = hasSidecar;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Motorbike | Has Sidecar: {HasSidecar}");
        }
    }
}
