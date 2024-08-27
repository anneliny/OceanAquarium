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
            HungerLevel = 0;
        }

        public Mackerel()
        {
            
        }


        public void FeedFish(List<IFish> fish)
        {
            bool inFeed = true;

            while (inFeed)
            {
                if (HungerLevel < 15)
                {
                    HungerLevel++;
                    Console.WriteLine($"Sultnivå makrell{Type}: {HungerLevel}"); //Hvorfor funker ikke type?
                }
                else
                {
                    Console.WriteLine("Makrellen er mett");
                    Console.ReadKey();
                }
                inFeed = false;
            }
        }
    }
}
