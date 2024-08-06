using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAccessModifiers
{
    public class Person
    {
        private int Age { get; set; }

        public int SetAge(int Age)
        {
            return this.Age = Age;
        }
        public void GetAge()
        {
            Console.WriteLine(Age);
        }

        public Person() { }
    }

}
