using System;
class TwoD{
    static void Main() {
        int n = 5; //Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name and age of 5 students :");
        string[,] sname = new string[n,2];
        for (int i = 0; i < 5; i++)
        {
           //  Console.WriteLine("Enter the name and age of 5 students :");
            Console.WriteLine("Enter the name" + (i + 1));
            sname[i, 0] = Console.ReadLine();
            Console.WriteLine("Enter the age" + (i + 1));
            sname[i, 1] = Console.ReadLine();

        }
        Console.WriteLine("Student Data :");
            for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("The " + (i+1) + "student name is : " + sname[i,0] + " and age is : "+ sname[i,1]);

        }

    }
}
