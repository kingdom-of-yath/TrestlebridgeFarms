using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompost
    {
        private int _seedsProduced = 40;
        private int _composted = 40;
        public string Type { get; } = "Sunflower";

        public double Harvest () {
            return _seedsProduced;
        }
        public double Compost () {
            return _composted;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}