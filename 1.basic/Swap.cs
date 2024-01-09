using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 22;
        int num2 = 65;

        int swaper = num1;
        num1 = num2;
        num2 = swaper;

        Console.WriteLine(num1+" "+num2);
        Console.WriteLine("after swap");
        Console.WriteLine(num1+" "+num2);


        Console.ReadLine();
    }
}