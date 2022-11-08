using System;
using System.Collections.Generic;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string currentStudent = Console.ReadLine();

            while (currentStudent != "end")
            {
                string[] file = currentStudent.Split();

                string firstName = file[0];
                string lastName = file[1];
                int age = int.Parse(file[2]);
                string city = file[3];

                Student student = new Student()
                {
                    Name = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city,
                };

                students.Add(student);
                currentStudent = Console.ReadLine();
            }

            string preferredCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.City == preferredCity)
                {
                    Console.WriteLine($"{student.Name} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }    

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
