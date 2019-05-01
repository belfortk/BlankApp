using System;
namespace HelloWorld
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public PresentationObject()
        {
        }

        public void Copy()
        {
            Console.WriteLine("Copy()");
        }

        public void Duplicate()
        {
            Console.WriteLine("Duplcate()");
        }
    }
}
