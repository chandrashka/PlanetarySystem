using System.Collections.Generic;
using Constants;

namespace Planetary.Enum
{
    public class MassClassEnum
    {
        private static MassClassEnum Asteroidan => new(GameConstants.Planetary.MinMassAsteroidan,
            GameConstants.Planetary.MaxMassAsteroidan,
            GameConstants.Planetary.MinRadiusAsteroidan,
            GameConstants.Planetary.MaxRadiusAsteroidan);

        private static MassClassEnum Mercurian => new(GameConstants.Planetary.MinMassMercurian,
            GameConstants.Planetary.MaxMassMercurian,
            GameConstants.Planetary.MinRadiusMercurian,
            GameConstants.Planetary.MaxRadiusMercurian);

        private static MassClassEnum Subterran => new(GameConstants.Planetary.MinMassSubterran,
            GameConstants.Planetary.MaxMassSubterran,
            GameConstants.Planetary.MinRadiusSubterran,
            GameConstants.Planetary.MaxRadiusSubterran);

        private static MassClassEnum Terran => new(GameConstants.Planetary.MinMassTerran,
            GameConstants.Planetary.MaxMassTerran,
            GameConstants.Planetary.MinRadiusTerran,
            GameConstants.Planetary.MaxRadiusTerran);

        private static MassClassEnum Superterran => new(GameConstants.Planetary.MinMassSuperterran,
            GameConstants.Planetary.MaxMassSuperterran,
            GameConstants.Planetary.MinRadiusSuperterran,
            GameConstants.Planetary.MaxRadiusSuperterran);

        private static MassClassEnum Neptunian => new(GameConstants.Planetary.MinMassNeptunian,
            GameConstants.Planetary.MaxMassNeptunian,
            GameConstants.Planetary.MinRadiusNeptunian,
            GameConstants.Planetary.MaxRadiusNeptunian);

        private static MassClassEnum Jovian => new(GameConstants.Planetary.MinMassJovian,
            GameConstants.Planetary.MaxMassJovian,
            GameConstants.Planetary.MinRadiusJovian,
            GameConstants.Planetary.MaxRadiusJovian);

        private MassClassEnum(float minMass, float maxMass, float minRadius, float maxRadius)
        {
            MinMass = minMass;
            MaxMass = maxMass;

            MinRadius = minRadius;
            MaxRadius = maxRadius;
        }

        public float MinMass { get; }
        public float MaxMass { get; }
        public float MinRadius { get; }
        public float MaxRadius { get; }

        public static IEnumerable<MassClassEnum> GetAllEnumValues()
        {
            return new List<MassClassEnum> { Asteroidan, Mercurian, Subterran, Terran, Superterran, Neptunian, Jovian };
        }
    }
}