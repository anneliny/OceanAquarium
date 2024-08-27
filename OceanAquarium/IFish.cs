using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OceanAquarium
{
    interface IFish
    {
        string Name { get; set; }
        string Size { get; set; }
        string Type { get; set; }
        int HungerLevel { get; set; }

        void FeedFish(List<IFish> fish);


    }
}
