namespace Service.Random
{
    public static class RandomExtensions
    {
        public static double NextDouble(
            this System.Random random,
            double minValue,
            double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}