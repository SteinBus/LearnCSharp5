using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp5
{
    internal class Person
    {
        private int _age;

        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            if ( age < 0 )
            {
                throw new ArgumentOutOfRangeException($"age({age}) can't be negative");
            }
        }
    }
}
