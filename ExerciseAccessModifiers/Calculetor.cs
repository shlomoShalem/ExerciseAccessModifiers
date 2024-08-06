using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAccessModifiers
{
    public class Calculetor
    {
        internal int Add(int x, int y) {  return x + y; } 
    }

    internal class MathOperations 
    {
        Calculetor calculetor = new Calculetor();
        public int AddNumber(int x, int y) 
        {
            return calculetor.Add(x, y);
        }
    }
}
