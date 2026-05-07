using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;
using System.Xml.Linq;

namespace Encapsulation_lab
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;
        public string FirstName
        {
            get { return this._firstName; }
            private set
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                this._firstName = value;
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            private set
            {
                if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                this._lastName = value;
            }
        }
        public int Age
        {
            get { return this._age; }
            private set
            {
                if (value < 0) throw new ArgumentException("Age cannot be zero or a negative integer!");
                this._age = value;
            }
        }
        public decimal Salary
        {
            get { return this._salary; }
            private set
            {
                if (value < 460) throw new ArgumentException("Salary cannot be less than 460 dollar!");
                this._salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

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
