using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ToyBox
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        private double _Price;
        public double Price { get; set; }

        private string Notes;

        public string GetNotes()
        {
            return Notes;
        }
        public void SetNotes(string Notes)
        {
            if (Notes.Length < 5)
            {
                return;
            }
            this.Notes = Notes;
        }

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Notes = string.Empty;
            Price = 0;
        }

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manu"></param>
        /// <param name="price"></param>
        /// <param name="note"></param>
        public Toy(string name, string manu, double price, string note)
        {
            Name = name;
            Manufacturer = manu;
            Price = price;
            Notes = note;
        }


        public string GetAisle()
        {
            string aisle = "";
            Random r = new Random();
            aisle = Manufacturer[0].ToString().ToUpper() + r.Next(1, 25);

            return aisle;
        }

        public override string ToString()
        {
            return $"{Name} is made by {Manufacturer} and sells for {Price.ToString("C")}\n{GetNotes()}";

            return "Banana";
            return base.ToString();
        }

    }
}
