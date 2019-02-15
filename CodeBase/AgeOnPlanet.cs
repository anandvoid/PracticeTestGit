using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    class AgeOnPlanet
    {
             
        
        public double AgeOnEarth { get; set; }
        
        public double SpaceAge(int seconds) => AgeOnEarth = seconds / 365.25 / 24 / 3600;
        public double OnEarth() => AgeOnEarth;
        public double OnMercury() => AgeOnEarth / 0.2408467;
        public double OnVenus() => AgeOnEarth / 0.61519726;
        public double OnMars() => AgeOnEarth / 1.8808158;
        public double OnJupiter() => AgeOnEarth / 11.862615;
        public double OnSaturn() => AgeOnEarth / 29.447498;
        public double OnUranus() => AgeOnEarth / 84.016846;
        public double OnNeptune() => AgeOnEarth / 164.79132;
    }
}
