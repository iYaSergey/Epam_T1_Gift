﻿using System.Collections.Generic;
using Gift.Model;

namespace Gift.Service
{
    public class GiftService : IGiftService
    {
        public double GetTotalWeight(Model.Gift gift)
        {
            double weight = 0;
            gift.Sweets.ForEach(o => weight += o.Weight * o.Count);
            return weight;
        }
        public List<Sweet> FindBySugarRange(Model.Gift gift, double min, double max) => gift.Sweets.FindAll(o => o.Sugar >= min && o.Sugar <= max);
        public void SortByName(Model.Gift gift) => gift.Sweets.Sort(Sweet.NameComparer);
        public void SortBySugar(Model.Gift gift) => gift.Sweets.Sort(Sweet.SugarComparer);
        public void SortByWeight(Model.Gift gift) => gift.Sweets.Sort(Sweet.WeightComparer);
        public void SortByCount(Model.Gift gift) => gift.Sweets.Sort(Sweet.CountComparer);
    }
}