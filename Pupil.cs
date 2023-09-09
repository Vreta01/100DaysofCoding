// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {
        //property for the name of a pupil object
        public string Title
        { get; private set; }

        //constructor assigning the name to a pupil
        public Pupil(string title)
        { Title = title; }

        //method for creating a storm object to cast
        public Storm CastWindStorm()
        {
            Storm pupilStorm = new Storm("wind", false, Title);
            return pupilStorm;
        }
    }
}
