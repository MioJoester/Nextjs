using System;

class Program
{
    static void Main()
    {
        
       int[] arr = { 1, 2, 3, 4 };
int sum = 0;

foreach (int n in arr)
{
    sum += n;
}

Console.WriteLine("Sum = " + sum);



    }
}
