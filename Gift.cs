using System;
using System.Collections.Generic;
using System.Linq;

namespace Gift
{
    public class Gift
    {
        public Gift()
        {
            Sweets = new List<Sweet>();
        }

        public List<Sweet> Sweets { get; }

        public override string ToString()
        {
            return String.Join("\n", Sweets);
        }

        public double GetTotalWeight()
        {
            double weight = 0;
            Sweets.ForEach(o => weight += o.Weight * o.Count);
            return weight;
        }
        public List<Sweet> FindBySugarRange(double min, double max) => Sweets.FindAll(o => o.Sugar >= min && o.Sugar <= max);

        public void Add(Sweet sweet) => Sweets.Add(sweet);
        public void Remove(Sweet sweet) => Sweets.Remove(sweet);

        public void SortByName() => Sweets.Sort(Sweet.NameComparer);
        public void SortBySugar() => Sweets.Sort(Sweet.SugarComparer);
        public void SortByWeight() => Sweets.Sort(Sweet.WeightComparer);
        public void SortByCount() => Sweets.Sort(Sweet.CountComparer);
    }
}