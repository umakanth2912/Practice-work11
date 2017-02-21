using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
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

            Dictionary<int, Student> dic = new Dictionary<int, Student>();
            dic.Add(Stud1.Id,Stud1);
            dic.Add(Stud2.Id, Stud2);
            dic.Add(Stud3.Id, Stud3);
            dic.Add(Stud4.Id, Stud4);

            Student st;
            if(dic.TryGetValue(123,out st))
            {
                Console.WriteLine("Student Id : {0}\n Student Name : {1}\n Student Age : {2}", st.Id, st.Name, st.Age);

            }
            else
            {
                Console.WriteLine("The value not exist");
            }

            Console.WriteLine("Total number of students with Age more than 24 years :{0}",dic.Count(va =>va.Value.Age>24));

            Console.ReadLine();
        }
    }
}
