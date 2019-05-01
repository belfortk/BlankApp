using System;
namespace HelloWorld
{
    public class Car : Vehicle
    {
        public Car(int registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car initialized ");
        }

        public override void TestMethod()
        {
            Console.WriteLine("test method");
        }

    }
}
