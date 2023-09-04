namespace Constants
{
    public static class GameConstants
    {
        public static class Factory
        {
            public const int MaximumPlanetsCount = 3;
            public static readonly int[] PlanetCoefficient = {5, 2, 1};
        }

    public static class Planetary
        {
            public const float MinMassAsteroidan = 0f;
            public const float MaxMassAsteroidan = 0.00001f;

            public const float MinRadiusAsteroidan = 0f;
            public const float MaxRadiusAsteroidan = 0.03f;


            public const float MinMassMercurian = 0.00001f;
            public const float MaxMassMercurian = 0.1f;

            public const float MinRadiusMercurian = 0.03f;
            public const float MaxRadiusMercurian = 0.7f;


            public const float MinMassSubterran = 0.1f;
            public const float MaxMassSubterran = 0.5f;

            public const float MinRadiusSubterran = 0.5f;
            public const float MaxRadiusSubterran = 1.2f;


            public const float MinMassTerran = 0.5f;
            public const float MaxMassTerran = 2;

            public const float MinRadiusTerran = 0.8f;
            public const float MaxRadiusTerran = 1.9f;


            public const float MinMassSuperterran = 2;
            public const float MaxMassSuperterran = 10;

            public const float MinRadiusSuperterran = 1.3f;
            public const float MaxRadiusSuperterran = 3.3f;


            public const float MinMassNeptunian = 10;
            public const float MaxMassNeptunian = 50;

            public const float MinRadiusNeptunian = 2.1f;
            public const float MaxRadiusNeptunian = 5.7f;


            public const float MinMassJovian = 50;
            public const float MaxMassJovian = 5000;

            public const float MinRadiusJovian = 3.5f;
            public const float MaxRadiusJovian = 27;
        }
    }
}