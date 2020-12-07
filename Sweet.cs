using System;
using System.Collections.Generic;

namespace Gift
{
    public abstract class Sweet
    {
        protected Sweet(string name, double sugar, double weight, int count)
        {
            Name = name;
            Sugar = sugar;
            Weight = weight;
            Count = count;
        }

        public string Name { get; }
        public double Sugar { get; }
        public double Weight { get; }
        public int Count { get; }

        public static IComparer<Sweet> NameComparer { get; } = new Sorters.NameRelationalComparer();
        public static IComparer<Sweet> SugarComparer { get; } = new Sorters.SugarRelationalComparer();
        public static IComparer<Sweet> CountComparer { get; } = new Sorters.CountRelationalComparer();
        public static IComparer<Sweet> WeightComparer { get; } = new Sorters.WeightRelationalComparer();

        public override string ToString()
        {
            return $"{Name}\nSugar: {Sugar}\tWeight: {Weight}\tCount: {Count}";
        }
    }
}