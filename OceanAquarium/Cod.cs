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
    
                if (HungerLevel <= 98 && HungerLevel != 0)
                {
                    HungerLevel += 6; //Når jeg mater fisken for fort, så skriver jeg over flere linjer under??
                }
        }

        public void HungerDecrease() 
        {

            if (HungerLevel > 0 && HungerLevel < 102)
            {
                HungerLevel -= 2;

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

                Console.WriteLine($"Du matet fisken så mye at den sprakk.");
            }

        }


    
        


    }
}
