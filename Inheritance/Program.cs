using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        private static bool ValuesOfRetile;

        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird = new Bird();
            
            bird.Toothless = true;
            bird.Fly = true;
            bird.WarmBlooded = true;
            bird.Heart = true;

            Retile retile = new Retile()
            {
                ColdBlood = true,
                LayEggs = 12,
                ScalySkin = true,
                Tail = 1

            };

            bird.ValuesOfBird();
            Console.WriteLine();
            retile.ValuesOfRetile();
           






            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
