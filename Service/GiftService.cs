using System.Collections.Generic;
using Gift.Model;
using Gift.Service.Sorters;

namespace Gift.Service
{
    public class GiftService : IGiftService
    {
        public static IComparer<Sweet> NameComparer { get; } = new NameRelationalComparer();
        public static IComparer<Sweet> SugarComparer { get; } = new SugarRelationalComparer();
        public static IComparer<Sweet> CountComparer { get; } = new CountRelationalComparer();
        public static IComparer<Sweet> WeightComparer { get; } = new WeightRelationalComparer();

        public double GetTotalWeight(Model.Gift gift)
        {
            double weight = 0;
            gift.Sweets.ForEach(o => weight += o.Weight * o.Count);
            return weight;
        }
        public List<Sweet> FindBySugarRange(Model.Gift gift, double min, double max) => gift.Sweets.FindAll(o => o.Sugar >= min && o.Sugar <= max);
        public void SortByName(Model.Gift gift) => gift.Sweets.Sort(NameComparer);
        public void SortBySugar(Model.Gift gift) => gift.Sweets.Sort(SugarComparer);
        public void SortByWeight(Model.Gift gift) => gift.Sweets.Sort(WeightComparer);
        public void SortByCount(Model.Gift gift) => gift.Sweets.Sort(CountComparer);
    }
}