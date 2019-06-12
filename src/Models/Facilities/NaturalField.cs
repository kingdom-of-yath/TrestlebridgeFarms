using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<ICompost>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<ICompost> _compostPlants = new List<ICompost>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (ICompost plant)
        {
            // TODO: implement this...
            try
            {
                _compostPlants.Add(plant);
            }
            catch( Exception )
            {
            throw new NotImplementedException();
            }
        }

        public void AddResource (List<ICompost> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._compostPlants.Count} plants\n");
            this._compostPlants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}