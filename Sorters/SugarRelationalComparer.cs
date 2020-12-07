using System.Collections.Generic;

namespace Gift.Sorters
{
    public sealed class SugarRelationalComparer : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.Sugar.CompareTo(y.Sugar);
        }
    }
}