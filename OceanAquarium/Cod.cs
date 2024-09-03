using System;
using System.Threading;

namespace OceanAquarium
{
    internal class Cod : IFish
    {

        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public int HungerLevel { get; set; }

        public Cod(string name, string size)
        {
            Name = name;
            Size = size;
            Type = "Torsk";
            HungerLevel = 50; 
        }


        public void FeedFish(List<IFish> fish)
        {
            bool inFeed = true;

            while (inFeed)
            {
                if (HungerLevel <= 98)
                {
                    HungerLevel += 5;
                }
                else
                {
                    Console.WriteLine("Torsken er mett");
                    Console.ReadKey();
                }
                inFeed = false;
            }
        }

        public void HungerDecrease(object? state) 
        {
            Console.SetCursorPosition(0, 0);
            if (HungerLevel > 0)
            {
                HungerLevel -= 2;

                Console.WriteLine($"Sultnivå {Type}: {HungerLevel} poeng");
            }
            else if (HungerLevel == 0)
            {
                Console.WriteLine("Fisken er mett");

            }
        }


    }
}
