﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace SampleEx302
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub s1 = new Sub();
            s1.showParam();
            Sub s2 = new Sub(100);
            s2.showParam();
        }
    }
}