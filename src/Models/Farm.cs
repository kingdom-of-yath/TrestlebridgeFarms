using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<DuckFarm> DuckFarms { get; } = new List<DuckFarm>();
        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource((IChicken)resource);
                    break;
                case "Duck":
                    DuckFarms[index].AddResource((IDuck)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
            Console.WriteLine ("Grazing Field Succesfully Created");
            Thread.Sleep(1500);
        }
        public void AddPlowedField (PlowedField field)
        {
            PlowedFields.Add(field);
            Console.WriteLine ("Plowed Field Succesfully Created");
            Thread.Sleep(1500);
        }

        public void AddChickenHouse (ChickenHouse field)
        {
            ChickenHouses.Add(field);
            Console.WriteLine ("Chicken house successfully created");
            Thread.Sleep(1500);
        }

        public void AddDuckFarm (DuckFarm field)
        {
            DuckFarms.Add(field);
            Console.WriteLine ("Duck house successfully created");
            Thread.Sleep(1500);

        }
        public void AddNaturalField (NaturalField field)
        {
            NaturalFields.Add(field);
            Console.WriteLine ("Natural Field successfully created");
            Thread.Sleep(1500);

        }
        

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));

            PlowedFields.ForEach(gf => report.Append(gf));

            ChickenHouses.ForEach(gf => report.Append(gf));

            DuckFarms.ForEach(gf => report.Append(gf));

            NaturalFields.ForEach(gf => report.Append(gf));

            return report.ToString();

        }



    }
}
