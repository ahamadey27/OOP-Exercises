using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Person
    {
        //hiding these variables are also known as encapsulation 
        private string name;
        private int age;

        //Adding constructor, has name name as class
        public Person(string initialName)
        {
            this.age = 0;
            this.name = initialName;
        }


    }
}