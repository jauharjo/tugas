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
            Person person = new Person("Nur", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Jauhar", 30, "191128", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Muslih", 19, "2832", "muslih@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
