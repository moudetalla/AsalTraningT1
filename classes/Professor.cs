using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Professor : Person
    {
        public Professor(string name) : base(name)
        {
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }

    }
}
