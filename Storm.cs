using System;

namespace MagicalInheritance
{
    class Storm
    {
        //public properties of a storm spell
        public string Essence
        { get; private set; }

        public bool IsStrong
        { get; private set; }

        public string Caster
        { get; private set; }

        //constructor to assign values to properties
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        //method to print the spell cast to the console
        public void Announce()
        {
            if (IsStrong)
            {
                Console.WriteLine($"{Caster} cast a strong {Essence} storm!");
            }
            else
            {
                Console.WriteLine($"{Caster} cast a weak {Essence} storm!");
            }
        }
    }
}
