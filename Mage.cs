// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        //inherited constructor from pupil
        public Mage(string arg) : base(arg)
        { }

        //method to create storm object to cast
        public virtual Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", false, Title);
            return rainStorm;
        }
    }
}
