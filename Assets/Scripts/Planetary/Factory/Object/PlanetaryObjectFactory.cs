using System;
using Planetary.Enum;
using Planetary.Object;
using Service.Random;
using Random = System.Random;

namespace Planetary.Factory.Object
{
    public class PlanetaryObjectFactory : IPlanetaryObjectFactory
    {
        private readonly Random _random = new();
        public IPlanetaryObject CreatePlanet(double mass)
        {
            var enumComponents = MassClassEnum.GetAllEnumValues();
            foreach (var enumValue in enumComponents)
            {
                if (MassRelateToClass(mass, enumValue))
                {
                    return CreatePlanetaryObject(mass, enumValue);
                }
            }
            
            throw new ArgumentException("Mass doesn`t relate to any of enum components");
        }

        private static bool MassRelateToClass(double mass, MassClassEnum massClassEnum)
        {
            return massClassEnum.MinMass <= mass && massClassEnum.MaxMass >= mass;
        }

        private IPlanetaryObject CreatePlanetaryObject(double mass, MassClassEnum massClassEnum)
        {
            return new PlanetaryObject
            {
                Mass = mass,
                Radius = _random.NextDouble(massClassEnum.MinRadius, massClassEnum.MaxRadius),
                MassClass = massClassEnum
            };
        }
    }
}