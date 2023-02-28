using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;
        public static int Count = 0;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count ++;
        }
        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                this.dateOfBirth=dateOfBirth;
            }
        }
        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Hi,I'm {FirstName} {LastName}, {GetDateOfBirth()}");
        }
    }
}
