﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//C#での継承の実装
namespace SampleEx301
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculatorクラスのインスタンス
            Calculator c1 = new Calculator();
            c1.Num1 = 10;
            c1.Num2 = 3;
            //足し算・引き算の結果を表示
            c1.add();
            c1.sub();
            ExCalculator c2 = new ExCalculator();
            c2.Num1 = 10;
            c2.Num2 = 3;
            //足し算・引き算の結果を表示
            c2.add();
            c2.sub();
            //掛け算・割り算の結果を表示
            c2.mul();
            c2.div();
        }
    }
}