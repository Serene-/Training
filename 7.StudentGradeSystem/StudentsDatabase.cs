using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StudentGradeSystem
{
    public class StudentsDatabase
    {
        public List<Student> students;
        public StudentsDatabase() 
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void RemoveStudent(string name)
        {
            var studentToRemove =students.FirstOrDefault(student => student.Name == name);
            if (studentToRemove != null) { students.Remove(studentToRemove); }
            else
            {
                Console.WriteLine($"Student with that {name} doesn't exists.");
            }
        }
        public void AllStudents()
        {
            Console.WriteLine("List of all students:");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} {student.Grade}");
            }
        }



        public void Update(string name)
        {
            var student = students.FirstOrDefault(x => x.Name == name);
            if(student!=null)
            {
                Console.WriteLine($"Please update the grade of student {name}");
                int grade = int.Parse(Console.ReadLine());
                student.Grade = grade;
            }
            else
            {
                Console.WriteLine("Student with that name doesn't exists.");
            }
        }
        public double AverageGrade()
        {
            double averageGrade=0;
            int count = 0;
            foreach(Student student in students)
            {
                averageGrade += student.Grade;
                count++;
            }
            averageGrade /= count;
            return averageGrade;
        }

    }
}
