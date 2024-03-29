using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class DuckFarm : IFacility<IDuck>
    {
        private int _capacity = 5;
        private Guid _id = Guid.NewGuid();

        private List<IDuck> _animals = new List<IDuck>();
        public List<IDuck> Animals
        {
            get
            {
                return _animals;
            }
        }

        public double Capacity {
            get {
                return _capacity;
            }
        }
        public int Duck()
        {
            return _animals.FindAll(animal => animal.Type == "Duck").Count;
        }

        public int GetCount {
            get {
                return _animals.Count;
            }
        }

        public void AddResource (IDuck animal)
        {
            try{
            _animals.Add(animal);
            }
            catch (Exception ){
            // TODO: implement this...
            throw new NotImplementedException();

            }
        }

        public void AddResource (List<IDuck> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck farm {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}