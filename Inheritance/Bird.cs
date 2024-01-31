using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    internal class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            HasBrain = true;
            Age = 10;
            Color = "Blue";
        }
        public bool Toothless { get; set; }
        public bool Fly { get; set; }
        public bool WarmBlooded { get; set; }
        public bool Heart { get; set; }

        public void ValuesOfBird()
        {
            Console.WriteLine($"Toothless{Toothless}");
            Console.WriteLine($"Fly {Fly}");
            Console.WriteLine($"Warm Blooded{WarmBlooded}");
            Console.WriteLine($"Heart{Heart}");
            Console.WriteLine($"Legs {Legs}");
        }
    }
}
