using System.Security.Cryptography.X509Certificates;

namespace FactoryDesignPattern
{
   public interface IVehicle
    {
        string VehicleType();
        int NumberOfWheels();
    }

    public class Bike : IVehicle
    {
        private readonly int numberofWheels;
        public Bike()
        {
                numberofWheels = 2;
        }
        public int NumberOfWheels()
        {
            return numberofWheels;
        }

        public string VehicleType()
        {
            return "Bike";
        }
    }
    public class Rikshaw : IVehicle
    {
        private readonly int numberofWheels;
        public Rikshaw()
        {
            numberofWheels = 3;
        }
        public int NumberOfWheels()
        {
            return numberofWheels;
        }

        public string VehicleType()
        {
            return "Rikshaw";
        }
    }

    public class Car : IVehicle
    {
        private readonly int numberofWheels;
        public Car()
        {
            numberofWheels = 4;
        }
        public int NumberOfWheels()
        {
            return numberofWheels;
        }

        public string VehicleType()
        {
            return "Car";
        }
    }
    public class Bus : IVehicle
    {
        private readonly int numberofWheels;
        public Bus()
        {
            numberofWheels = 6;
        }
        public int NumberOfWheels()
        {
            return numberofWheels;
        }

        public string VehicleType()
        {
            return "Bus";
        }
    }

    public class Factory
    {
  
        public static IVehicle GetInstance(VehicleType vehicleType)
        {
           IVehicle vehicle = null;
            switch (vehicleType)
            {
                case VehicleType.bike:
                    vehicle = new Bike();
                    break;
                case VehicleType.car:
                    vehicle = new Car();
                    break;
                case VehicleType.bus:
                    vehicle = new Bus();
                    break;
                default:
                    throw new Exception("This method is not implemented yet");
            }
            return vehicle;            
        }
    }
   public enum VehicleType
    {
        bike = 1,
        car = 2,
        bus = 3,
        truck = 4
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = Factory.GetInstance(VehicleType.truck);
            Console.WriteLine(vehicle.NumberOfWheels() + " : " + vehicle.VehicleType());
            Console.WriteLine("Hello, World!");
        }
    }
}