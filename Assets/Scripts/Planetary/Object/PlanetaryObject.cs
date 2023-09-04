using Planetary.Enum;

namespace Planetary.Object
{
    public class PlanetaryObject : IPlanetaryObject
    {
        public MassClassEnum MassClass { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }
    }
}