using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanAquarium
{
    internal class TimerClass
    {
        public Timer Timer { get; set; }
        public Cod Cod { get; set; }
        public SeaTrout SeaTrout { get; set; }

        public TimerClass(Cod cod, SeaTrout seaTrout)
        {
            Cod = cod;
            SeaTrout = seaTrout;

            Timer = new Timer(GetHungerDecrease, null, 10, 1000);
        }

        public void GetHungerDecrease(object? state)
        {
            Console.SetCursorPosition(0, 0);
            Cod.HungerDecrease();

            Console.SetCursorPosition(0, 1);
            SeaTrout.HungerDecrease();
        }

        

    }

}
