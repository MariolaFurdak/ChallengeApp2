﻿namespace ChallengeApp2
{
    public abstract class Person
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get;private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
    }
}
