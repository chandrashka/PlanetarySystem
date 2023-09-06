using System.Collections.Generic;
using Constants;
using Planetary.Object;
using Service.Random;
using UnityEngine;

namespace Service.Initializer
{
    public class PlanetaryInitializer : MonoBehaviour
    {
        [SerializeField] private List<GameObject> planetsPrefabs;

        public void CreatePlanet(IPlanetaryObject planetaryObject, List<GameObject> planetary)
        {
            var randomPrefabCount = RandomExtensions.Random.Next(planetsPrefabs.Count);
            var position = CalculatePosition(planetaryObject, planetary);

            var createdPlanetary = Instantiate(planetsPrefabs[randomPrefabCount],
                position, Quaternion.identity);

            var radius = (float)planetaryObject.Radius;
            createdPlanetary.transform.localScale = new Vector3(radius, radius, radius);

            planetary.Add(createdPlanetary);
        }

        private Vector3 CalculatePosition(IPlanetaryObject planetaryObject, List<GameObject> planetaryList)
        {
            if (planetaryList.Count <= 0)
                return new Vector3
                (GameConstants.Planetary.ExtraSpaceBetweenPlanets, 0,
                    GameConstants.Planetary.ExtraSpaceBetweenPlanets);

            var planetaryDiameter = (float)planetaryObject.Radius * 2 +
                                    GameConstants.Planetary.ExtraSpaceBetweenPlanets;

            var previousPlanetPosition = planetaryList[^1].transform.position;

            var position = new Vector3(previousPlanetPosition.x + planetaryDiameter, 0,
                previousPlanetPosition.z + planetaryDiameter);

            return position;
        }
    }
}