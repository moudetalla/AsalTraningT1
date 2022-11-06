using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var person = new Person("Mohammad");
            person.Greet();



            var student = new Student("Ahmad");
            student.SetAge(18);
            student.Greet();
            student.ShowAge();


            var prof = new Professor("Saleh");
            prof.SetAge(48);
            prof.Greet();

            prof.Explain();





        }
    }
}
