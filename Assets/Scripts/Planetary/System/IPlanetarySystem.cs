using System.Collections.Generic;
using Planetary.Object;

namespace Planetary.System
{
    public interface IPlanetarySystem
    {
        IEnumerable<IPlanetaryObject> PlanetaryObjects { get; set; }

        void Update();
        void SetPlanets(IEnumerable<IPlanetaryObject> planetaryObjects);
    }
}