using System;

namespace Person_class
{
    class Person
    {
        public string name;
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {name}");
        }
    }
}