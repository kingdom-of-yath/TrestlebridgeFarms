using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompost
    {
        // private int _seedsProduced = 40;
        private int _composted = 40;
        public string Type { get; } = "Wildflower";

        // public double Harvest () {
        //     return _seedsProduced;
        // }
        public double Compost () {
            return _composted;
        }

        public override string ToString () {
            return $"Wildflower. Yuck!";
        }
    }
}