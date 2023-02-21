using System;

namespace Inheritance
{
    class Program
    {
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
            var tucan = new Bird();
            tucan.beakLength = 2;
            tucan.hasTalons = false;
            tucan.colorFeathers = "black";
            tucan.diet = "fruit";



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var gecko = new Reptile();
            gecko.IsScaly = true;
            gecko.ColdBlooded = true;
            gecko.Diet = "insects";
            gecko.Habitat = "watery place";
            gecko.legs = 4;

            var myAnimals = new Animal[] { tucan, gecko };
            foreach (var animal in myAnimals )
            {
                Console.WriteLine($"Legs:{animal.legs}");
                Console.WriteLine($"Fur:{animal.hasFur}");
                Console.WriteLine($"Tail:{animal.hasTail}");
                Console.WriteLine($"Teeth:{animal.teeth}");
                Console.WriteLine($"");

            }
        }
    }
}
