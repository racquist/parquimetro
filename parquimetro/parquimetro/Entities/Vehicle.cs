using parquimetro.Entities.Enums;
using System.Text;

namespace parquimetro.Entities
{
    class Vehicle
    {
        public string VehiclePlate { get; set; }
        public VehicleStatus Status { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string vehiclePlate, VehicleStatus status)
        {
            VehiclePlate = vehiclePlate;
            Status = status;
        }

        public void parkPeriod(DateTime start, DateTime end)
        {
            TimeSpan preiod = end.Subtract(start);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Vehicle Plate: " + VehiclePlate + "      Status: " + Status);
            return sb.ToString();
        }
    }
}
