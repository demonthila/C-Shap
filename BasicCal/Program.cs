﻿namespace BasicCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            

            Console.WriteLine(num1 + num2);
        }
    }
}