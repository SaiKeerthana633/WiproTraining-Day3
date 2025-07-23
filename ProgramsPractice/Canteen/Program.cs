// See https://aka.ms/new-console-template for more information
//using System;

class Canteen
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        int cs = 0, cm = 0, cl = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int v = 0;
        int c;
        Console.WriteLine("---Daily Coupon Summary-------");
        foreach (int t in arr)
        {
            if (t <= 50)
            {
                cs = cs + 1;
            }
            else if (t <= 100 && t >= 51)
            {
                cm = cm + 1;
            }
            else
            {
                cl = cl + 1;
            }
            v = Math.Max(v, t);
            sum = sum + t;
        }
        c = arr.Length;
        Console.WriteLine("Total coupons redeemed: " + c);
        Console.WriteLine("Total value collected :" + sum);
        Console.WriteLine("Highest coupon redeemed: " + v +"\n") ;


        Console.WriteLine("Category break down");
        Console.WriteLine("Small (<=50) :" + cs);
        Console.WriteLine("Medium (51-100) :" + cm);
        Console.WriteLine("Large (>100) :" + cl);
    }
}
