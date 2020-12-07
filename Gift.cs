using System.Collections.Generic;

namespace Gift
{
    public class Gift
    {
        public Gift()
        {
            Sweets = new List<Sweet>();
        }

        public List<Sweet> Sweets { get; }

        public void Add(Sweet sweet)
        {
            Sweets.Add(sweet);
        }
    }
}