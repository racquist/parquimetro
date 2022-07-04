using System;
using System.Globalization;
using System.Collections.Generic;
using parquimetro.Entities;
using parquimetro.Entities.Enums;

namespace parquimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Driver data");
            Console.Write("Driver name: ");
            string name = Console.ReadLine();
            Console.Write("Driver License number: ");
            int driverId = int.Parse(Console.ReadLine());
            
            List<Vehicle> vehicles = new List<Vehicle>();
            Driver driver = new(name, driverId, 0, vehicles);
            
            Console.Write("Chose the value of your first credits charge: $");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Payment Type:(creditCard / transitAgent / parkMachine) ");
            PaymentCategory category = Enum.Parse<PaymentCategory>(Console.ReadLine());
            Console.Write("Operation number: ");
            int opNumber = int.Parse(Console.ReadLine());

            Payment payment = new Payment(category, opNumber, amount);
            driver.addCredit(amount);
            
            Console.WriteLine("Now registry your vehicle(s)");
            Console.Write("How many vehicles you want to registry: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
                 

            for(int i = 1; i <= x; i++)
            {
                Console.Write("insert the vehicle#" + i + " Plate: ");
                string plate = Console.ReadLine();
                VehicleStatus status = VehicleStatus.outUse;
                Vehicle vehPlate = new Vehicle(plate, status); 
                driver.addVehicle(vehPlate);
            }
            Console.WriteLine();
            Console.WriteLine("Register Information:");
            Console.WriteLine(driver);
            Console.WriteLine();
            Console.WriteLine("Vehicles Registred:");
            Console.WriteLine();
            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
            Console.WriteLine();
            Console.WriteLine("Credit / Debit operations: ");
            Console.WriteLine();
            Console.WriteLine(payment);
        }
    }
}