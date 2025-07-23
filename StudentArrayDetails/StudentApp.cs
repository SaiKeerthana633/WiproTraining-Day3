using System;
using StudentP;
class StudentApp
{
    static void Main(string [] args)
    {
        int noofStudent = 2;
        Student[] students = new Student[noofStudent];
        for (int i = 0; i < noofStudent; i++)
        {
            students[i] = new Student();
            Console.WriteLine("Enter a Name:");
            students[i].Name = Console.ReadLine();
            Console.WriteLine("Enter a Age:");
            students[i].Age = Convert.ToInt32(Console.ReadLine());
            int subcount = Convert.TOInt32(Console.ReadLine());
            students[i].StuMarks = new Student[subcount];
            foreach (Student n in students)
            {
                Console.WriteLine("Enter the Marks");
                students[i].n = Convert.ToInt32(Console.ReadLine());

            }

        }
        foreach (Student s in students)
        //     for (int i = 0; i < noofStudent; i++)
        {
            Console.WriteLine("Name:" + s.Name);
            Console.WriteLine("Age:" + s.Age);
            foreach (int v in s.n)
            { 
                Console.WriteLine("Enter the Marks" + v);
            }
        }
    }
}
