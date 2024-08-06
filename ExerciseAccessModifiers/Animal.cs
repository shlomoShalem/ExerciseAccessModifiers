using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAccessModifiers
{
    public class Animal
    {
        protected string Species {  get; set; } = string.Empty;

        public Animal() { }
        public string GetSpecies()
        {
           return Species;
        }
    }

    public class Dog : Animal 
    {
        public Dog() 
        {
            Species = GetSpecies();
        }

    }
}
