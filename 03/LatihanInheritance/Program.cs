using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nur", 19);
            person.GetNameAndAge();

            var teacher = new Teacher("Jauhar", 30, "191128", "Math");
            teacher.GetNameAndAge();

            var student = new Student("Muslih", 19, "2832", "muslih@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
