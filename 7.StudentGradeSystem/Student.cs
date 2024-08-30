using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StudentGradeSystem
{
    public class Student
    {
        public string Name { get;private set; }
        public int Grade { get; set; }
        public Student(string name,int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
