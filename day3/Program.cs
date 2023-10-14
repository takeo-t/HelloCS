// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//for文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     // for(int i = 1;i <= 5; i++)
        //     // for(int i = -2 ; i <= 2 ; i++)
        //     for(int i = 12; i > 0; i-=3 )
        //     {
        //         Console.Write(i+" ");
        //     }
        //     Console.WriteLine();
        // }
        // //2重for文
        // {
        //     for(int i = 1; i <= 2; i++){
        //         for(int j = 1; j <= 3; j++){
        //             int k = i + j;
        //             Console.Write(i + "+" + j + "=" + k +" ");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        // while文
        // {
        //     int i = 0;
        //     while( i <= 5 ){
        //         Console.Write(i+" ");
        //         i++;
        //     }
        //     Console.WriteLine();
        // }
        //do～while文
        // {
        //     int i = 0;
        //     do{
        //         Console.Write(i+" ");
        //         i++;
        //     }while(i <= 5);
        //     Console.WriteLine();
        // }
        //無限ループ
        // {
        //     Random rnd = new Random();
        //     Console.WriteLine("6が出たら終了");
        //     while(true){
        //         int dice = rnd.Next(1,7);//  1以上7未満の乱数を発生させる（1から6まで）
        //         Console.WriteLine(dice);
        //         if(dice == 6){
        //             break;//ループから抜ける
        //         }
        //     }
        //     Console.WriteLine("終了");
        // }

        //prob 4-1
        // {
        //     Console.Write("整数値を入力");
        //     int inputNum = int.Parse(Console.ReadLine());
        //     for(int i = 0; i < inputNum; i++){
        //         Console.Write("▫️");
        //     }
        //     Console.WriteLine();
        // }

        // //prob 4-8
        // {
        //     while(true)
        //     {
        //         Console.WriteLine("0以上の数値を入力してください。");
        //         int inputNum;
        //         if(int.TryParse(Console.ReadLine(), out inputNum))//入力値が数字であることをチェック
        //         {
        //             if(inputNum >= 0){
        //                 Console.WriteLine(inputNum);
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //         else
        //         {
        //         Console.WriteLine("数字を入力してください。");
        //         }
        //     }
        // Console.WriteLine("終了します");
        // }

        // //prob 4-17
        // {
        //     int size = 10;
        //     for(int i = 1; i <= size; i++){
        //         for(int j = 1; j <= i; j++){
        //             Console.Write("■");
        //         }
        //         for(int j = i+1; j <= size; j++){
        //             Console.Write("□");
        //         }
        //         Console.WriteLine();
        //     }
        // }
        // //prob 4-18
        // {
        //     int size = 10;
        //     for(int i = 1; i <= size; i++){
        //         for(int j = 1; j <= size; j++){
        //             if(i == j){Console.Write("□");
        //             } else {
        //                 Console.Write("■");
        //             }
        //         }
        //         Console.WriteLine();
        //     }
        // }
        {
            int size = 10;
            for (int i = 1; i <= size; i++){
                for (int j = 1; j <= i; j++){
                Console.Write("□");
                }
                for (int j = i+1; j <= size; j++){
                Console.Write("◼️");
                } Console.WriteLine();
            }
        }
    }
}