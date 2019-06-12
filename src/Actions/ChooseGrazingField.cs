using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();
            List<GrazingField> CapacityList = farm.GrazingFields.Where(thing => thing.GetCount < thing.Capacity).ToList();
            if(CapacityList.Count == 0)
            {
                Console.WriteLine(" All Fields are at Capacity");
                Console.WriteLine("Press return key to return to Main Menu");
                Console.ReadLine();
                return;
            } else {
                for (int i = 0; i < CapacityList.Count; i++) {
                if(CapacityList[i].GetCount < farm.GrazingFields[i].Capacity) 
                Console.WriteLine($"Grazing Field: {i + 1}");
                Console.WriteLine($"Grazing Field ({CapacityList[i].Animals.Count} Total Animals - {CapacityList[i].Cows()} cow, {CapacityList[i].Pig()} pig, {CapacityList[i].Goat()} goat, {CapacityList[i].Ostrich()} ostrich, {CapacityList[i].Sheep()} sheep) ");
                Console.WriteLine();

            }} 
            Console.WriteLine();

            Console.WriteLine();
            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");
            int choice = Int32.Parse(Console.ReadLine());

            CapacityList[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}