namespace Service.Random
{
    public static class RandomExtensions
    {
        public static readonly System.Random Random = new();

        public static double NextDouble(double minValue, double maxValue)
        {
            return Random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}