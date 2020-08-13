using System;
namespace practice
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Middle { get; } = "";

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            Middle = middle;
            LastName = last;
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public string AllCaps() => ToString().ToUpper();

    }
}
