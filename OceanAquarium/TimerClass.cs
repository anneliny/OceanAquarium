using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanAquarium
{
    internal class TimerClass
    {
        public System.Threading.Timer timer { get; set; }
        public Cod Cod { get; set; }

        public TimerClass(Cod cod)
        {
            Cod = cod;
            
            timer = new System.Threading.Timer(Cod.HungerDecrease, null, 1000, 1000);
        }
        

    }

}
