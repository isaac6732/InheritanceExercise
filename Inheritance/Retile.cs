using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Retile : Animal
    {
        
        public bool ColdBlood { get; set; }
        public int  LayEggs { get; set; }
        public bool ScalySkin { get; set; }
        public int Tail { get; set; }

        public void ValuesOfRetile()
        {
            Console.WriteLine($"Cold Blood{ColdBlood}");
            Console.WriteLine($"Lay Eggs{LayEggs}");
            Console.WriteLine($"Scaly Skin{ScalySkin}");
            Console.WriteLine($"Tail{Tail}");
            Console.WriteLine($"Legs {Legs}");
        }
    }
}
