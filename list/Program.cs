using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Stud1 = new Student()
            {
                Id = 123,
                Name = "Umakanth",
                Age = 24
            };
            Student Stud2 = new Student()
            {
                Id = 124,
                Name = "Ravi kumar",
                Age = 25
            };
            Student Stud3 = new Student()
            {
                Id = 125,
                Name = "Nikhil kumar",
                Age = 26
            };
            Student Stud4 = new Student()
            {
                Id = 126,
                Name = "Pawan",
                Age = 30
            };
            List<Student> stu = new List<Student>();
            stu.Add(Stud1);
            stu.Add(Stud2);
            stu.Add(Stud3);
            stu.Add(Stud4);

            foreach(Student studen in stu)
            {
                Console.WriteLine("Student Id : {0}\n Student Name : {1}\n Student Age : {2}", studen.Id, studen.Name, studen.Age);
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
