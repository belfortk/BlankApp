using System;
namespace HelloWorld
{
    public class Vehicle
    {
        private readonly int registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle initialized");
        //}

        public Vehicle(int registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }

        public virtual void TestMethod()
        {
            Console.WriteLine("test method");
        }
    }
}
