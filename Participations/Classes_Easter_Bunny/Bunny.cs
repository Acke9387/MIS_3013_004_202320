using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Easter_Bunny
{
    public class Bunny
    {

        public string Name { get; set; }

        public int Age { get; set; }
        public string DeliveryDate { get; set; }

        public int BasketSize { get; set; }

        public string EggColor { get; set; }

        public int EggCount { get; set; }

        public string Location { get; set; }
        public string FavoriteColor { get; set; }

        // Create an empty constructor setting all properties to default empty values
        public Bunny()
        {
            Name = "";
            Age = 0;
            DeliveryDate = "";
            BasketSize = 0;
            EggColor = "";
            EggCount = 0;
            Location = "";
            FavoriteColor = "";
        }

        // create an overloaded constructor that accepts the name and age of the bunny
        public Bunny(string name, int age)
        {
            Name = name;
            Age = age;
            DeliveryDate = "";
            BasketSize = 0;
            EggColor = "";
            EggCount = 0;
            Location = "";
            FavoriteColor = "";
        }

        public int HowManyEasterBaskets()
        {
            // Calculate how many baskets the bunny will need to deliver the eggs and take the ceiling
            int baskets = (int)Math.Ceiling((double)EggCount / BasketSize);
            baskets = EggCount / BasketSize;


            return baskets;
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old and loves the color {FavoriteColor} and will deliver {EggCount.ToString("N")} eggs on {DeliveryDate} in {Location}.";
        }

    }
}
