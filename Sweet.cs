namespace Gift
{
    public abstract class Sweet
    {
        protected Sweet(int sugar, int weight, int count)
        {
            Sugar = sugar;
            Weight = weight;
            Count = count;
        }

        public int Sugar { get; }
        public int Weight { get; }
        public int Count { get; }
    }
}