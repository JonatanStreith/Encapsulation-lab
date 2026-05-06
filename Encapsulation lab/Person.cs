using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_lab
{
    internal class Person(string firstName, string lastName, int age, decimal salary)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set; } = lastName;
        public int Age { get; private set; } = age;
        public decimal Salary { get; private set; } = salary;

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary} dollars.";
        }


        public void IncreaseSalary(decimal percentage)
        {
            Salary += Salary * percentage;
        }
    }
}
