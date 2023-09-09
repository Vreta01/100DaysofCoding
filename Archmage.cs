// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        //inherited constructor from pupil through mage
        public Archmage(string arg) : base(arg)
        { }

        //methods to create storm object to cast
        public override Storm CastRainStorm()
        {
            Storm archRainStorm = new Storm("rain", true, Title);
            return archRainStorm;
        }
        public Storm CastLightningStorm()
        {
            Storm archLightningStorm = new Storm("lightning", true, Title);
            return archLightningStorm;
        }
    }
}
