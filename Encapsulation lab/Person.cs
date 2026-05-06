using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;
using System.Xml.Linq;

namespace Encapsulation_lab
{
    internal class Person(string firstName, string lastName, int age, decimal salary)
    {
        public string FirstName
        {
            get;
            private set { if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer than 3 symbols!"); }
        } = firstName;
        public string LastName
        {
            get;
            private set { if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols!"); }
        } = lastName;
        public int Age
        {
            get;
            private set { if (value < 0) throw new ArgumentException("Age cannot be zero or a negative integer!"); }
        } = age;
        public decimal Salary
        {
            get;
            private set { if (value < 460) throw new ArgumentException("Salary cannot be less than 460 dollar!"); }
        } = salary;

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
