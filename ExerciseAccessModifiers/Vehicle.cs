using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAccessModifiers
{
    public class Vehicle
    {
        protected string Model {  get; set; } = string.Empty;
        private int EngineCapacity { get; set; } = 2000; 
        public Vehicle() { }
        public int GetEngineCapacity() { return EngineCapacity; }
    }
    
    public class Car : Vehicle 
    {
        public int NumberOfDoors { get; set; }
        public Car(string midel, int numberOfDoors) 
        {
            Model = midel;
            NumberOfDoors = numberOfDoors;
        }

        public string GetDetailsOfCar()
        {
            return $"the model of car:{Model}, the num of car doors: {NumberOfDoors}, the engine capacity: {GetEngineCapacity()}.";
        }
    }
}
