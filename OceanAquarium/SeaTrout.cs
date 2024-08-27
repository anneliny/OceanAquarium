using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OceanAquarium
{
    internal class SeaTrout : IFish
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type{ get; set; }
        public int HungerLevel { get; set; }


        public SeaTrout(string name, string size)
        {
            Name = name;
            Size = size;
            Type = "Sjø ørret";
            HungerLevel = 0;

        }

        public SeaTrout()
        {
            
        }

        public void FeedFish(List<IFish> fish)
        {
            bool inFeed = true;

            while (inFeed)
            {
                if (HungerLevel < 12)
                {
                    HungerLevel++;
                    Console.WriteLine($"Sultnivå sjø ørett{Type}: {HungerLevel}"); //Hvorfor funker ikke type?
                }
                else
                {
                    Console.WriteLine("Sjø øretten er mett");
                    Console.ReadKey();
                }
                inFeed = false;
            }
        }
    }
}
