using System.Collections.Generic;
using Planetary.Object;
using UnityEngine;

namespace Service.Initializer
{
    public class PlanetaryInitializer : MonoBehaviour
    {
        [SerializeField] private List<GameObject> planetsPrefabs;
        
        private readonly System.Random _random = new();
        
        private const float ExtraSpace = 3f;
        
        public void CreatePlanet(IPlanetaryObject planetaryObject, int degreePerSecond, List<int> degreesPerSecond, List<GameObject> planetary)
        {
            degreesPerSecond.Add(degreePerSecond);

            var randomPrefabCount = _random.Next(planetsPrefabs.Count);
            var position = CalculatePosition(planetaryObject, planetary);

            var createdPlanetary = Instantiate(planetsPrefabs[randomPrefabCount], position, Quaternion.identity);

            var radius = (float)planetaryObject.Radius;
            createdPlanetary.transform.localScale = new Vector3(radius, radius, radius);

            planetary.Add(createdPlanetary);
        }
        
        private Vector3 CalculatePosition(IPlanetaryObject planetaryObject, List<GameObject> planetary)
        {
            if (planetary.Count <= 0) return new Vector3(ExtraSpace, 0, ExtraSpace);
            
            var planetaryDiameter = (float)planetaryObject.Radius * 2 + ExtraSpace;
            var previousPlanetPosition = planetary[^1].transform.position;

            var position = new Vector3(previousPlanetPosition.x + planetaryDiameter, 0,
                previousPlanetPosition.z + planetaryDiameter);

            return position;

        }
    }
}