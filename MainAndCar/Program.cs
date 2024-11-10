using System;

namespace MainAndCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(vehicleId: 1, make: "Toyota", model: "Camry", fuelEfficiency: 15.0f, numDoors: 4, isAutomatic: true);

            float distance = 150.0f;
            Console.WriteLine("Fuel Consumption Calculations:");

            float carFuelConsumption = car.CalculateFuelConsumption(distance);
            Console.WriteLine("Car (ID: " + car.VehicleId + ", Model: " + car.Make + " " + car.Model + ") for " + distance + " km: " + carFuelConsumption.ToString("F2") + " liters");


            Console.ReadLine();
        }

       
    }
    public class Vehicle 
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public float FuelEfficiency { get; set; }

        public Vehicle(int vehicleId, string make, string model, float fuelEfficiency)
        {
            VehicleId = vehicleId;
            Make = make;
            Model = model;
            FuelEfficiency = fuelEfficiency;
        }
    }

    public class Car : Vehicle
    {
        public int NumDoors { get; set; }
        public bool IsAutomatic { get; set; }

        public Car(int vehicleId, string make, string model, float fuelEfficiency, int numDoors, bool isAutomatic)
            : base(vehicleId, make, model, fuelEfficiency)
        {
            NumDoors = numDoors;
            IsAutomatic = isAutomatic;
        }

        public float CalculateFuelConsumption(float distance)
        {
            return distance / FuelEfficiency;
        }
    }
}
