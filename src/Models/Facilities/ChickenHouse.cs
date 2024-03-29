using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<IChicken>
    {
        private int _capacity = 5;
        private Guid _id = Guid.NewGuid();

        private List<IChicken> _animals = new List<IChicken>();
        public int Chicken()
        {
            return _animals.FindAll(animal => animal.Type == "Chicken").Count;
        }
        public List<IChicken> Animals
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

        public int GetCount {
            get {
                return _animals.Count;
            }
        }

        public void AddResource (IChicken animal)
        {
            // TODO: implement this...
            try{
            _animals.Add(animal);
            }
            catch (Exception ){
            // TODO: implement this...
            throw new NotImplementedException();

            }
        }

        public void AddResource (List<IChicken> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}