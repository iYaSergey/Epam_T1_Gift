using System;
using System.Collections.Generic;

namespace Gift.Model
{
    public class Gift
    {
        public List<Sweet> Sweets { get; }

        public Gift()
        {
            Sweets = new List<Sweet>();
        }
        public override string ToString()
        {
            return String.Join("\n", Sweets);
        }
        public void Add(Sweet sweet) => Sweets.Add(sweet);
        public bool Remove(Sweet sweet) => Sweets.Remove(sweet);
    }
}