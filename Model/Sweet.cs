using System.Collections.Generic;
using Gift.Service.Sorters;

namespace Gift.Model
{
    public abstract class Sweet
    {
        public string Name { get; }
        public double Sugar { get; }
        public double Weight { get; }
        public int Count { get; }

        public static IComparer<Sweet> NameComparer { get; } = new NameRelationalComparer();
        public static IComparer<Sweet> SugarComparer { get; } = new SugarRelationalComparer();
        public static IComparer<Sweet> CountComparer { get; } = new CountRelationalComparer();
        public static IComparer<Sweet> WeightComparer { get; } = new WeightRelationalComparer();
        public override string ToString()
        {
            return $"{Name}\nSugar: {Sugar}\tWeight: {Weight}\tCount: {Count}";
        }

        protected Sweet(string name, double sugar, double weight, int count)
        {
            Name = name;
            Sugar = sugar;
            Weight = weight;
            Count = count;
        }
    }
}