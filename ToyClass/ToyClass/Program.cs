using System;
using System.Collections.Generic;

namespace ToyMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            List<string> toyCollection = new List<string>();
            
            //Toy 1
            Toy t1 = new Toy();
            
            //Passing values to the toy class
            t1.Manufacturer = "The Lego Group";
            t1.Name = "Lego Classis Brick Set";
            t1.Price = 15.99;
            t1.SetNotes("This toy is for children ages 4+.");

            //Adding toy 1 to collection as well as outputting information to user
            toyCollection.Add(t1.Name);
            Console.WriteLine("Toy 1");
            Console.WriteLine($"Toy Manufacturer is: \t{t1.GetAisle()}");
            Console.WriteLine($"The toy name is: \t{t1.Name}");
            Console.WriteLine($"The toy cost is: \t{t1.Price.ToString("C")}");
            Console.WriteLine($"Notes about the toy: \t{t1.GetNotes()}");

            //Toy 2
            Toy t2 = new Toy();

            //Passing values to the toy class
            t2.Manufacturer = "Kellytoy Worldwide, Inc.";
            t2.Name = "20” Star Wars The Child Squishmallows Plush";
            t2.Price = 27.99;
            t2.SetNotes("This toy is for children ages 3+.");

            //Adding toy 2 to collection as well as outputting information to user
            toyCollection.Add(t2.Name);
            Console.WriteLine("Toy 2");
            Console.WriteLine($"Toy Manufacturer is: \t{t2.GetAisle()}");
            Console.WriteLine($"The toy name is: \t{t2.Name}");
            Console.WriteLine($"The toy cost is: \t{t2.Price.ToString("C")}");
            Console.WriteLine($"Notes about the toy: \t{t2.GetNotes()}");

            //Toy 3
            Toy t3 = new Toy();

            //Passing values to the toy class
            t3.Manufacturer = "Mattel";
            t3.Name = "Hot Wheels 50-Car Pack";
            t3.Price = 48.99;
            t3.SetNotes("This toy is for children ages 3+.");

            //Adding toy 3 to collection as well as outputting information to user
            toyCollection.Add(t3.Name);
            Console.WriteLine("Toy 3");
            Console.WriteLine($"Toy Manufacturer is: \t{t3.GetAisle()}");
            Console.WriteLine($"The toy name is: \t{t3.Name}");
            Console.WriteLine($"The toy cost is: \t{t3.Price.ToString("C")}");
            Console.WriteLine($"Notes about the toy: \t{t3.GetNotes()}");
        }
    }
}
    