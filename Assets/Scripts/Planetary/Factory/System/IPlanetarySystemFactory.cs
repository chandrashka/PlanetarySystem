using Planetary.System;

namespace Planetary.Factory.System
{
    public interface IPlanetarySystemFactory
    {
        public IPlanetarySystem Create(double mass);
    }
}