using System.Collections.Generic;
using System.Linq;
using Constants;
using Planetary.Factory.Object;
using Planetary.Object;
using Planetary.System;
using Unity.VisualScripting;

namespace Planetary.Factory.System
{
    public class PlanetarySystemFactory : IPlanetarySystemFactory
    {
        private readonly IPlanetaryObjectFactory _planetaryObjectFactory = new PlanetaryObjectFactory();

        public IPlanetarySystem Create(double mass)
        {
            IPlanetarySystem threePlanetPlanetarySystem = GetPlanetarySystemComponent();

            threePlanetPlanetarySystem.SetPlanets(CreatePlanets(mass));

            return threePlanetPlanetarySystem;
        }

        private IEnumerable<IPlanetaryObject> CreatePlanets(double mass)
        {
            var multiplyCoefficient = GetMultiplyCoefficient(mass);

            var planets = new List<IPlanetaryObject>();

            for (var planetNumber = 0; planetNumber < GameConstants.Factory.PlanetCoefficient.Length; planetNumber++)
                planets.Add(_planetaryObjectFactory.CreatePlanet(GetMass(multiplyCoefficient, planetNumber)));

            return planets;
        }

        private static PlanetarySystem GetPlanetarySystemComponent()
        {
            return UnityEngine.Object.FindObjectOfType<GameManager.GameManager>().AddComponent<PlanetarySystem>();
        }

        private static double GetMultiplyCoefficient(double mass)
        {
            return mass / GameConstants.Factory.PlanetCoefficient.Sum();
        }

        private static double GetMass(double coefficientMultiply, int planetNumber)
        {
            return coefficientMultiply * GameConstants.Factory.PlanetCoefficient[planetNumber];
        }
    }
}