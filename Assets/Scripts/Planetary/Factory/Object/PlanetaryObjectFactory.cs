using System;
using Planetary.Enum;
using Planetary.Object;
using Service.Random;
using UnityEngine;

namespace Planetary.Factory.Object
{
    public class PlanetaryObjectFactory : IPlanetaryObjectFactory
    {
        public IPlanetaryObject CreatePlanet(double mass)
        {
            var enumComponents = MassClassEnum.GetAllEnumValues();
            foreach (var enumValue in enumComponents)
                if (MassRelateToClass(mass, enumValue))
                    return CreatePlanetaryObject(mass, enumValue);

            throw new ArgumentException("Mass doesn`t relate to any of enum components");
        }

        private static bool MassRelateToClass(double mass, MassClassEnum massClassEnum)
        {
            return massClassEnum.MinMass <= mass && massClassEnum.MaxMass >= mass;
        }

        private IPlanetaryObject CreatePlanetaryObject(double mass, MassClassEnum massClassEnum)
        {
            Debug.Log("Planetary mass: " + mass);
            return new PlanetaryObject
            {
                Mass = mass,
                Radius = RandomExtensions.NextDouble(massClassEnum.MinRadius, massClassEnum.MaxRadius),
                MassClass = massClassEnum
            };
        }
    }
}