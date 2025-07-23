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
            students[i].Naame = Console.ReadLine();
            Console.WriteLine("Enter a Age:");
            students[i].Agee = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Name:" + s.Naame);
            Console.WriteLine("Age:" + s.Agee);
            foreach (int v in s.n)
            { 
                Console.WriteLine("Enter the Marks" + v);
            }
        }
    }
}