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

        public static IComparer<Sweet> NameComparer { get; } = new NameRelationalComparer();
        public static IComparer<Sweet> SugarComparer { get; } = new SugarRelationalComparer();
        public static IComparer<Sweet> CountComparer { get; } = new CountRelationalComparer();
        public static IComparer<Sweet> WeightComparer { get; } = new WeightRelationalComparer();

        public override string ToString()
        {
            return $"{Name}\nSugar: {Sugar}\nWeight: {Weight}\nCount: {Count}\n";
        }

        private sealed class NameRelationalComparer : IComparer<Sweet>
        {
            public int Compare(Sweet x, Sweet y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
        }
        private sealed class SugarRelationalComparer : IComparer<Sweet>
        {
            public int Compare(Sweet x, Sweet y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.Sugar.CompareTo(y.Sugar);
            }
        }
        private sealed class CountRelationalComparer : IComparer<Sweet>
        {
            public int Compare(Sweet x, Sweet y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.Count.CompareTo(y.Count);
            }
        }
        private sealed class WeightRelationalComparer : IComparer<Sweet>
        {
            public int Compare(Sweet x, Sweet y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.Weight.CompareTo(y.Weight);
            }
        }
    }
}