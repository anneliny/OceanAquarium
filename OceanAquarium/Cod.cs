using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OceanAquarium
{
    internal class Cod : IFish
    {

        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public int HungerLevel { get; set; }
        public int CountdownCod { get; set; }

        public Cod(string name, string size)
        {
            Name = name;
            Size = size;
            Type = "Torsk";
            HungerLevel = 5; //Hvorfor funker det ikke å starte på 5?
            CountdownCod = 10;
        }
        public Cod()
        {
            
        }

        public void FeedFish(List<IFish> fish)
        {
            bool inFeed = true;

            while (inFeed)
            {
                if (HungerLevel <= 10)
                {
                    HungerLevel++;
                    Console.WriteLine($"Sultnivå torsk{Type}: {HungerLevel}"); //Hvorfor funker ikke type?
                }
                else
                {
                    Console.WriteLine("Torsken er mett");
                    Console.ReadKey();
                }
                inFeed = false;
            }
        }


        //public void Countdown()
        //{

        //    if (HungerLevel < 10)
        //    {

        //        Thread.Sleep(1000);

        //        Console.WriteLine($"Sultnivå for torsk: {CountdownCod} sekunder"); //Ikke ferdig, bare prøvd mye forskjellig.
        //    }
        //}
    }
}
