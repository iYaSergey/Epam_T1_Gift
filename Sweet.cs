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

        public override string ToString()
        {
            return $"{Name}\nSugar: {Sugar}\nWeight: {Weight}\nCount: {Count}\n";
        }

        public string Name { get; }
        public double Sugar { get; }
        public double Weight { get; }
        public int Count { get; }
    }
}