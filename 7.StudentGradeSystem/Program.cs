namespace _7.StudentGradeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentsDatabase studentsDatabase = new StudentsDatabase();
            Console.WriteLine("Student Grade Management System");
            Console.WriteLine("1.Add a Student");
            Console.WriteLine("2.Update a Student's Grade");
            Console.WriteLine("3.Remove a Student");
            Console.WriteLine("4.Display All Students");
            Console.WriteLine("5.Calculate Average Grade");
            Console.WriteLine("6.Exit");
            string command = Console.ReadLine();
            while (command != "6")
            {
                switch (command)
                {
                    case "1":
                        {
                            Console.WriteLine("Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Grade");
                            int grade = int.Parse(Console.ReadLine());
                            Student student = new Student(name, grade);
                            studentsDatabase.AddStudent(student);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter the name of a student");
                            string name = Console.ReadLine();
                            studentsDatabase.Update(name);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Enter the name of a student you want to remove");
                            string name = Console.ReadLine();
                            studentsDatabase.RemoveStudent(name);
                            break;
                        }
                    case "4":
                        {
                            studentsDatabase.AllStudents();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Average grade is {0:0.00}", studentsDatabase.AverageGrade());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                        
                }
                Console.WriteLine("Enter a new option:");
                command = Console.ReadLine();
            }
        }
    }
}
