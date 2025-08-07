using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Person
    {
        //The static modifier indicates that the method does not
        //belong to an object and thus cannot be used to access any variables that belong to objects.

        //hiding these variables are also known as encapsulation 
        private string name;
        private int age;

        //Adding constructor, has name name as class
        public Person(string initialName)
        {
            this.age = 0;
            this.name = initialName;
        }

        //objects method
        public void PrintPerson()
        {
            System.Console.WriteLine($"{this.name}, age {this.age} years ");
        }


    }
}