using System.Timers;

namespace OceanAquarium
{
    internal class Main
    {
        public List<IFish> fish { get; set; }
        public Cod Cod { get; set; }
        public Mackerel Mackerel { get; set; }
        public SeaTrout SeaTrout { get; set; }
        public TimerClass TimerClass { get; set; }

        public Main()
        {
            fish = new List<IFish>()
            {
                new Mackerel("Markus", "Medium"),
                new Mackerel("Maren", "Liten"),
                new Cod("Torstein", "Stor"),
                new Cod("Tomine", "Medium"),
                new SeaTrout("Øyvind", "Stor"),
                new SeaTrout("Øystein", "Medium")

            };

            Cod = new Cod("Tobias", "Stor");
            Mackerel = new Mackerel("Martine", "Liten");
            SeaTrout = new SeaTrout("Ørjan", "Medium");
            TimerClass = new TimerClass(Cod);
            Console.SetCursorPosition(0, 3);
            Menu();
        }



        public void Menu()
        {
            bool inMenu = true;

            while (inMenu)
            {

                Console.WriteLine("Velkommen til sjø akvariet!");
                Console.WriteLine("Hva vil du gjøre?\n");
                Console.WriteLine("1. Se på alle fiskene");
                Console.WriteLine("2. Mat fiskene");

                var inputMenu = Console.ReadLine();

                switch (inputMenu)
                {
                    case "1":
                        ShowFish();
                        break;

                    case "2":
                        FishFeeding();
                        break;

                    default:
                        System.Environment.Exit(0);
                        break;
                }

            }

        }

        public void ShowFish()
        {
            foreach (IFish fish in fish)
            {
                Console.WriteLine($"Navn: {fish.Name}");
                Console.WriteLine($"Størrelse: {fish.Size}");
                Console.WriteLine($"Art: {fish.Type}\n");
            }
        }

        public void FishFeeding()
        {
            Console.WriteLine("Fiskene trenger mat, men må mates med ulike ting og mengde.");
            Console.WriteLine("Pass på at de verken blir for sultne eller for mette!");
            Console.WriteLine("1. For å mate torsken");
            Console.WriteLine("2. For å mate makrellen");
            Console.WriteLine("3. For å mate sjøørreten");


            bool inFishFeeding = true;

            while (inFishFeeding)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Cod.FeedFish(fish);
                        break;

                    case "2":
                        Mackerel.FeedFish(fish);
                        break;

                    case "3":
                        SeaTrout.FeedFish(fish);
                        break;

                    default:
                        inFishFeeding = false;
                        Console.Clear();
                        break;
                }
            }


        }
    }
}
