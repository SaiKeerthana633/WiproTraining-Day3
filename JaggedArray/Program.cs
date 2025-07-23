using System;
class JaggedArray
{
    static void Main()
    {
        int n = 3;
        string[] sname = new string[n];
        string[][] stsubject = new string[n][];
        Console.WriteLine("Let's save name and their subjects of 3 students :");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter name of student " + (i + 1));
            sname[i] = Console.ReadLine();
            Console.WriteLine("How many subjects you want to store ");
            int subcount = Convert.ToInt32(Console.ReadLine());
            stsubject[i] = new string[subcount];
            for (int j = 0; j < subcount; j++)
            {
                Console.WriteLine("Enter the subjects");
                stsubject[i][j] = Console.ReadLine();
               // Console.WriteLine(stsubject[i][j]);
            }
        }
            Console.WriteLine("Enter the data name and subject");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name:" + (i + 1) + sname[i]);
                for (int j = 0; j < stsubject[i].Length; j++)
                {
                    Console.WriteLine("Enter the age:" + (i + 1) + stsubject[i][j]);
                }
            }
        
        
    }
}

//create a jagged array to store 5 student names and their subject
 //like student 1 has taken 2 subjs , student 2 has taken 4 subjects and so on
// by taking input from an user and then display