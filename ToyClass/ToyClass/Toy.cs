using System;
using System.Collections.Generic;
using System.Text;

namespace ToyMain
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        public string GetNotes()
        {
            return Notes;
        }

        public void SetNotes(string note)
        {
            Notes = note;
        }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public string GetAisle()
        {
            int ranNum;
            Random ran = new Random();
            ranNum = ran.Next(1, 25);
            return $"{Manufacturer.ToUpper()[0]}{Manufacturer.Substring(1)} {ranNum}";
        }
    }
}
