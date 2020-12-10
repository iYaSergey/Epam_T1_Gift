using System.Collections.Generic;
using Gift.Model;

namespace Gift.Service
{
    public interface IGiftService
    {
        public double GetTotalWeight(Model.Gift gift);
        public List<Sweet> FindBySugarRange(Model.Gift gift, double min, double max);
        void SortByName(Model.Gift gift);
        void SortBySugar(Model.Gift gift);
        void SortByWeight(Model.Gift gift);
        void SortByCount(Model.Gift gift);
    }
}