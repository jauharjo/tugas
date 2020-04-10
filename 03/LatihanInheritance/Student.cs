
namespace LatihanInheritance
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }
        public Student(string name, int age, string studentid, string email) : base(name, age)
        {
            this.StudentId = studentid;
            this.Email = email;
        }
    }
}
