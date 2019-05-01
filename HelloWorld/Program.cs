using System;
using System.IO;
using System.Collections.Generic;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            //var customer = new Customer { Id = 0, Name = "mark" };

            //var order = new Order();

            //customer.Orders.Add(order);

            //var point = new Point(10, 20);

            //point.Move(new Point(5, 10));

            //Console.WriteLine($"new point location should be 5,10  and is {point.X},{point.Y}");

            //var person = new Person(new DateTime(1999, 1, 1));


            //var cookie = new HttpCookie();
            //cookie["name"] = "kyle";
            //Console.WriteLine(cookie["name"]);

            //var text = new Text();
            //text.Width = 100;

            //var logger = new Logger();
            //var installer = new Installer(logger);
            //var dbMigrator = new DbMigrator(logger);
            //dbMigrator.Migrate();
            //installer.Install();


            Func<int, string> test = num => $"IT WORKS!!! {num}";

            Console.WriteLine(test(12));


            var list = new List<Point>();
            list.Add(new Point() { X = 1, Y = 2 });
            list.Add(new Point() { X = 10, Y = 2 });
            list.Add(new Point() { X = 15, Y = 2 });
            list.Add(new Point() { X = 2, Y = 2 });
            list.Add(new Point() { X = 8, Y = 2 });

            var lesser = list.FindAll(point => point.X < 10);


        }
    }
}