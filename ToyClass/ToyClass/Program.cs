using System;

namespace ToyMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy t1 = new Toy();
            
            t1.Manufacturer = "the lego group";
            t1.Name = "Lego Classis Brick Set";
            t1.Price = 15.99;
            t1.SetNotes("This toy is for children ages 4+.");
            
            Console.WriteLine(t1.GetAisle());
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.Price.ToString("C"));
            Console.WriteLine(t1.GetNotes());
        }
    }
}
    