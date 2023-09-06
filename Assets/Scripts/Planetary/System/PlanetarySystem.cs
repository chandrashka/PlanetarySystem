using System.Collections.Generic;
using Constants;
using Planetary.Object;
using Service.Initializer;
using Service.Random;
using UnityEngine;

namespace Planetary.System
{
    public class PlanetarySystem : MonoBehaviour, IPlanetarySystem
    {
        public IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set; }

        private readonly List<GameObject> _planetary = new();

        private bool _isSystemCreated;

        private readonly List<int> _degreesPerSecondList = new();

        private readonly Vector3 _target = Vector3.zero;

        private PlanetaryInitializer _planetaryInitializer;

        private void Awake()
        {
            _planetaryInitializer = FindObjectOfType<PlanetaryInitializer>();
        }

        public void Update()
        {
            if (_isSystemCreated) return;

            foreach (var planet in _planetary)
                MovePlanet(planet, _planetary.IndexOf(planet));
        }

        private void MovePlanet(GameObject planet, int indexOf)
        {
            planet.transform.RotateAround(_target, Vector3.down,
                _degreesPerSecondList[indexOf] * Time.deltaTime);
        }

        public void SetPlanets(IEnumerable<IPlanetaryObject> planetaryObjects)
        {
            PlanetaryObjects = planetaryObjects;
            foreach (var planetary in PlanetaryObjects)
            {
                var degreePerSecond = 
                    RandomExtensions.Random.Next(GameConstants.Planetary.MaximumDegreesPerSecond);
                _degreesPerSecondList.Add(degreePerSecond);
                _planetaryInitializer.CreatePlanet(planetary, _planetary);
            }
        }
    }
}