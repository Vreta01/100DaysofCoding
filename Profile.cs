using System;

namespace DatingProfile
{
    class Profile
    {
        //fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        //constructors
        public Profile(string name, int age, string city = "", string country = "", string pronouns = "they/them")
        {
            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }
        //properties
        private string Name
        {
            get;
            set;
        }
        private int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        //methods
        public string ViewProfile()
        {
            if (age == 0)
            {
                return "You are too young to date!";

            }
            else if (age > 18)
            {
                string info = $"{name}\n{age} | {pronouns}\n{city}, {country}\n";
                string hobbyList = "";
                foreach (string hobby in hobbies)
                {
                    hobbyList = hobbyList + "\n" + hobby;
                }
                hobbyList = hobbyList + ".";
                return (info + hobbyList);
            }
            else
            {
                return "ERROR: Age invalid";
            }
        }
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}
