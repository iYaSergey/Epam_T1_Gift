namespace Gift.Model
{
    public abstract class Sweet
    {
        public string Name { get; }
        public double Sugar { get; }
        public double Weight { get; }
        public int Count { get; }

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