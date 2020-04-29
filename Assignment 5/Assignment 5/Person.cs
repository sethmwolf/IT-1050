using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class Person
    {

        private string FirstName;
        private string LastName;
        private string FullName;

        public Person(string first, string last)
        {

            this.FirstName = first;
            this.LastName = last;
            this.FullName = this.FirstName + " " + this.LastName;

        }

        public void PrintFullName()

        {

            System.Console.WriteLine(this.FullName);

        }


    }
}
