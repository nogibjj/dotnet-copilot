//build a hello world program that prints out two numbers added together
//the numbers are 5 and 6
//the output should be 11

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 6;
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}