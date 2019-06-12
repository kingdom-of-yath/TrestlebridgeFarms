using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseDuckFarm {
        public static void CollectInput (Farm farm, IDuck animal) {
            Console.Clear();

        List<DuckFarm> CapacityList = farm.DuckFarms.Where(thing => thing.GetCount < thing.Capacity).ToList();
            
            if(CapacityList.Count == 0)
            {
                Console.WriteLine(" All Fields are at Capacity");
                Console.WriteLine("Press return key to return to Main Menu");
                Console.ReadLine();
                return;
            } else {
                for (int i = 0; i < CapacityList.Count; i++) {
                if(CapacityList[i].GetCount < farm.DuckFarms[i].Capacity) 
                Console.WriteLine($"{i + 1}: Number of Ducks in the Duck Farm {CapacityList[i].GetCount}");

            }} 

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());

            CapacityList[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}