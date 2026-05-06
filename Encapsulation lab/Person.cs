using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_lab
{
    internal class Person(string firstName, string lastName, int age)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set; } = lastName;
        public int Age { get; private set; } = age;

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
