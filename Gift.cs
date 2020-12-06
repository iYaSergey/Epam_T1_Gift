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
    }
}