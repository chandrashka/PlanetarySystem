using Planetary.Enum;

namespace Planetary.Object
{
    public interface IPlanetaryObject
    {
        MassClassEnum MassClass { get; set; }
        double Mass { get; set; }
        double Radius { get; set; }
    }
}