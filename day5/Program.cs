// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace Sample502
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//              double[] d = new double[3];
//              d[0] = 1.2;
//              d[1] = 3.7;
//              d[2] = 4.1;    //  変数の代入
//              double sum,avg; //  合計値、平均値を入れる変数
//              sum = 0.0;
//              for(int i = 0; i < d.Length; i++){
//                  Console.Write(d[i] + " ");
//                  sum += d[i];
//             }
//             Console.WriteLine();
//             avg = sum / d.Length;
//             Console.WriteLine("合計値：" + sum);
//             Console.WriteLine("平均値：" + avg);
//         }
//     }
// }

// namespace Sample503
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] n = { 5,4,3,2,1 };
//             string[] s = { "ABC","DEF","GHI" };
//             int i;
//             //  整数型配列変数nの成分表示
//             for(i = 0; i < n.Length; i++){
//                 Console.Write(n[i]+" ");
//             }
//             Console.WriteLine();
//             //  文字列型配列変数nの成分表示
//             for(i = 0; i < s.Length; i++){
//                 Console.Write(s[i]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// namespace Sample504
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] n = { 1, 2, 3, 4 };
//             foreach(int i in n){
//                 Console.Write("{0} ",i);
//             }
//             Console.WriteLine();
//         }
//     }
// }

// namespace Sample505
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[,] a = new int[3, 4];
//             int m, n;
//             for (m = 0; m < 3; m++){
//                 for (n = 0; n < 4; n++){
//                     a[m,n] = m+n;
//                 }
//             }

//             for (m = 0; m < 3; m++)
//             {
//                 for (n = 0; n < 4; n++)
//                 {
//                     Console.Write("a[{0},{1}]={2} ", m, n, a[m, n]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// namespace Sample506
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[][] a = new int[][]{new int[]{0,1},new int[]{2},new int[]{3,4,5,6}};
//             for(int m = 0; m < a.Length; m++){
//                 for(int n = 0; n < a[m].Length; n++){
//                 Console.Write(a[m][n]+" ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }