using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Inventory = new List<string>()
        {
            "Camry", "F-150", "MDX", "Camry", "Camry",
            "Taurus", "F-150", "MDX", "Camry", "Xterra",
            "Mustang", "Suburban", "Santa Fe", "F-150", "Camry",
            "F-150", "F-150", "Mustang", "Camry", "Camry",
            "Camry", "Escalade", "Q30", "Camry", "MDX",
        };

            HashSet<string> allModels = new HashSet<string>();

            foreach (string model in Inventory)
            {
                allModels.Add(model);
            }

            // Display all unique model names
            foreach (string vehicle in allModels)
            {
                Console.WriteLine($"{vehicle}");
            }
            // Create an empty HashSet named Showroom that will contain strings.
            // Add four of your favorite car model names to the set.
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Ferrari");
            Showroom.Add("Lambo");
            Showroom.Add("Ford Ka");
            Showroom.Add("Reliant Robin");

            // Print to the console how many cars are in your show room.
            Console.WriteLine($"The showroom has {Showroom.Count} cars in it.");

            // Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Ford Ka");

            // Print your showroom again, and notice how there's still only one representation of that model in there.
            Console.WriteLine($"The showroom has {Showroom.Count} cars in it.");

            // Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> usedLot = new HashSet<string>();
            usedLot.Add("Chevrolet Sonic");
            usedLot.Add("Toyota");

            Console.WriteLine($"The used lot has {usedLot.Count} cars in it.");
            // Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(usedLot);

            Console.WriteLine($"The showroom has {Showroom.Count} cars in it.");
            // You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Ferrari");

            Console.WriteLine($"The showroom has {Showroom.Count} cars in it.");

            foreach (string car in Showroom)
            {
                Console.WriteLine($"{car}");
            }

            /*
            Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has
            approached you about buying the entire inventory.
            In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
             */

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Ford Ka");
            Junkyard.Add("Reliant Robin");
            Junkyard.Add("Malibu");
            Junkyard.Add("Tundra");
            Junkyard.Add("F150");
            Junkyard.Add("Equinox");

            // Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);
            HashSet<string> clone = new HashSet<string>(Showroom);

            // Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.
            clone.IntersectWith(Junkyard);

            foreach (string junk in clone)
            {
                Console.WriteLine($"clone: {junk}");
            }

            // Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);

            Console.WriteLine($"The showroom has {Showroom.Count} cars in it.");

            foreach (string newcar in Showroom)
            {
                Console.WriteLine($"{newcar}");
            }
            // Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
            Showroom.Remove("Malibu");
            Showroom.Remove("Tundra");
            Showroom.Remove("F150");

            // Count cars in showroom after removing the new cars acquired from Junkyard.
            Console.WriteLine($"The showroom has {Showroom.Count} cars in it.");

            // Display each car in showroom after above

            foreach (string finalCars in Showroom)
            {
                Console.WriteLine($"Final Showroom: {finalCars}");
            }
        }

    }
}
