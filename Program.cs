using System;
using static System.Net.Mime.MediaTypeNames;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a pupil/mage/archmage object to cast spells
            Storm pupilOne = new Storm("wind", false, "Zul\'rajas");
            Pupil pupilTwo = new Pupil("Mezil-kree");
            Mage mageOne = new Mage("Gul\'dan");
            Archmage archOne = new Archmage("Nielas Aran");

            //create a storm object for each mage
            Storm pupilWind = pupilTwo.CastWindStorm();
            Storm mageRain = mageOne.CastRainStorm();
            Storm archRain = archOne.CastRainStorm();
            Storm archLightning = archOne.CastLightningStorm();

            //call Announce method to print to console
            pupilOne.Announce();
            pupilWind.Announce();
            mageRain.Announce();
            archRain.Announce();
            archLightning.Announce();
        }
    }
}
