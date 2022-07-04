using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace parquimetro.Entities
{
    class Driver
    {
        public string Name { get; set; }
        public int LicenseId { get; set; }
        public double CreditsBalance { get; set; }
        public List<Vehicle> Vehicles  { get; set; } = new List<Vehicle>();

        public Driver()
        {
        }
        public Driver(string name, int licenseId, double creditsBalance, List<Vehicle> vehicles)
        {
            Name = name;
            LicenseId = licenseId;
            CreditsBalance = creditsBalance;
            Vehicles = vehicles;
        }


        public void addVehicle(Vehicle plate)
        {
            Vehicles.Add(plate);
        }

        public void removeVehicles(Vehicle plate)
        {
            Vehicles.Remove(plate);
        }

        public void addCredit(double amount)
        {
            CreditsBalance += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Driver: " + Name + "     Driver License number: " + LicenseId + "    Current Credit: $" + CreditsBalance.ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
