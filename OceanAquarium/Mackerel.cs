using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OceanAquarium
{
    internal class Mackerel : IFish
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public int HungerLevel { get; set; }

        public Mackerel(string name, string size)
        {
            Name = name;
            Size = size;
            Type = "Makrell";
            HungerLevel = 60;
        }

        public void FeedFish(List<IFish> fish)
        {
            if (HungerLevel <= 100 && HungerLevel != 0)
            {
                HungerLevel += 8;
            }
        }

        public void HungerDecrease()
        {

            if (HungerLevel > 0 && HungerLevel < 100)
            {
                HungerLevel -= 4;

                Console.WriteLine($"Sultnivå {Type}: {(HungerLevel.ToString().Length == 1 ? ("0" + HungerLevel) : HungerLevel)} poeng"); //???
            }
            else if (HungerLevel <= 0)
            {
                Main.ClearLine();

                Console.WriteLine("Fisken sultet ihjel");
            }
            else if (HungerLevel >= 100)
            {
                Main.ClearLine();

                Console.WriteLine("Du matet fisken så mye at den sprakk.");
            }
        }

    }
}
