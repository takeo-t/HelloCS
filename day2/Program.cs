// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample301
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     Console.Write("整数値を入力");
        //     int a = int.Parse(Console.ReadLine());
        //     Console.WriteLine("a="+a);
        //     if(a > 0){
        //         Console.WriteLine("aは正の数です。");
        //     }
        //      else
        //     {
        //         Console.WriteLine("aは正の数ではありません。");
        //     }
        // }
        // //if~else文
        // {
        //         Console.Write("1から3の整数を入力:");
        //         int num = int.Parse(Console.ReadLine());
        //         if(num == 1){
        //         Console.WriteLine("one");
        //         }else if(num == 2){
        //         Console.WriteLine("two");
        //         }else if(num == 3){
        //         Console.WriteLine("three");
        //         }else{
        //         Console.WriteLine("不適切な値です。");
        //     }
        // }
        // //ネストしたif文
        // {
        //     Console.Write("サイコロの目（1〜6）:");
        //     int dice = int.Parse(Console.ReadLine());
        //     if(1 <= dice && dice <= 6){
        //         if(dice == 2 || dice == 4 || dice == 6){
        //             Console.WriteLine("丁（チョウ）です。");
        //         }else{
        //             Console.WriteLine("半 （ハン）です。");
        //         }
        //     }else{
        //         Console.WriteLine("範囲外の数値です。");
        //     }
        // }
        // // Swich文
        // {
        //     Console.Write("サイコロの目(1~6):");
        //     int dice = int.Parse(Console.ReadLine());
        //     switch(dice)
        //     {
        //         case 1:
        //         case 3:
        //         case 5:
        //             Console.WriteLine("丁（チョウ）です。");
        //             break;
        //         case 2:
        //         case 4:
        //         case 6:
        //             Console.WriteLine("半（ハン）です。");
        //             break;
        //         default:
        //             Console.WriteLine("範囲外の数値です。");
        //             break;
        //     }
        // }
        //prob 3-2
        // {
        //     Console.Write("整数値を入力");
        //     int inputNum = int.Parse(Console.ReadLine());
        //     if(inputNum != 4){
        //         Console.WriteLine("4ではありません。");
        //     }else{
        //         Console.WriteLine("4ですね😃");
        //     }
        // }
        //prob3-17
        {
            Console.Write("1から100までの整数値を入力してください:");
            int inputNum = int.Parse(Console.ReadLine());
            if( inputNum <= 50 && inputNum % 2 == 0){
                Console.WriteLine("50以下の偶数です。");
            }else if( inputNum % 2 == 0){
                Console.WriteLine("偶数です。");
            }else if( inputNum <= 50 ){
                Console.WriteLine("50以下です。");
            }else{
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}