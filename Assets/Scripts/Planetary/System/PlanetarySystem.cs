using System.Collections.Generic;
using Planetary.Object;
using Service.Initializer;
using UnityEngine;
using Random = System.Random;

namespace Planetary.System
{
    public class PlanetarySystem : MonoBehaviour, IPlanetarySystem
    {
        public IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set; }

        private readonly List<GameObject> _planetary = new();

        private bool _isSystemCreated;

        private readonly List<int> _degreesPerSecond = new();

        private readonly Vector3 _target = Vector3.zero;
        
        private readonly Random _random = new();

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
            planet.transform.RotateAround(_target, Vector3.down, _degreesPerSecond[indexOf] * Time.deltaTime);
        }
        
        public void SetPlanets(IEnumerable<IPlanetaryObject> planetaryObjects)
        {
            PlanetaryObjects = planetaryObjects;
            foreach (var planetary in PlanetaryObjects) 
                _planetaryInitializer.CreatePlanet(planetary, _random.Next(180), _degreesPerSecond, _planetary);
        }

    }
}