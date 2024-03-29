using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 5;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public int Cows()
        {
            return _animals.FindAll(animal => animal.Type == "Cow").Count;
        }
        public int Pig()
        {
            return _animals.FindAll(animal => animal.Type == "Pig").Count;
        }
        public int Ostrich()
        {
            return _animals.FindAll(animal => animal.Type == "Ostrich").Count;
        }
        public int Sheep()
        {
            return _animals.FindAll(animal => animal.Type == "Sheep").Count;
        }
        public int Goat()
        {
            return _animals.FindAll(animal => animal.Type == "Goat").Count;
        }


        public int GetCount {
            get {
                return _animals.Count;
            }
        }
        public List<IGrazing> Animals
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

        public void AddResource (IGrazing animal)
        {
            try{
            _animals.Add(animal);
            }
            catch (Exception ){
            // TODO: implement this...
            throw new NotImplementedException();

            }
        }

        public void AddResource (List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}