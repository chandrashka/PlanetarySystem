using Planetary.Factory.System;
using UnityEngine;

namespace GameManager
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private double systemMass;

        private IPlanetarySystemFactory _planetarySystemFactory;

        private void Start()
        {
            _planetarySystemFactory = new PlanetarySystemFactory();
            _planetarySystemFactory.Create(systemMass);
        }
    }
}