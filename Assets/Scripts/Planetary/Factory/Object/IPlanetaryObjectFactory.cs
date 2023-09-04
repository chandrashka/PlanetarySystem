using Planetary.Object;

namespace Planetary.Factory.Object
{
    public interface IPlanetaryObjectFactory
    {
        public IPlanetaryObject CreatePlanet(double mass);
    }
}