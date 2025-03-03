using System.Security.Cryptography;

namespace Vehicle
{
    public class Vehicle
    {
        public string owner { get; set; }
        public Vehicle()
        { 
            owner = "zs";
        }
       
        
    }

    public class Car : Vehicle
    {
        public Car()
        {
           owner = "ls";
        }
        public void Drive()
        {
            System.Console.WriteLine("Driving");
        }
    }
}
