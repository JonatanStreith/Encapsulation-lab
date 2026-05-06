using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_lab
{
    internal class Person (string firstName, string lastName, int age)
    {
        private string FirstName = firstName;
        private string LastName = lastName;
        private int Age = age;

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
