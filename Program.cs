using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            // C#での演算処理について理解
            // int a;
            // int b = 3;
            // int add,sub;
            // double avg;
            // a = 6;
            // add = a + b;
            // sub = a - b;
            // avg = (a + b) / 2.0;
            // Console.WriteLine("{0} + {1} = {2}", a, b, add);
            // Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            // Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);

            // 代入演算子の練習
            // int a1=2,b1=2,c1=2,d1=2;
            // int a2=2,b2=2,c2=2,d2=2;

            // a1 = a1 + 1;
            // b1 = b1 + 1;
            // c1 = c1 + 1;
            // d1 = d1 + 1;

            // キャストの練習
            // a2 += 1;
            // b2 -= 1;
            // c2 *= 2;
            // d2 /= 2;
            // Console.WriteLine("a1={0} b1={1} c1={2} d1={3}",a1,b1,c1,d1);
            // Console.WriteLine("a2={0} b2={1} c2={2} d2={3}",a2,b2,c2,d2);

            // int a;
            // double b,c,d;
            // a = (int)1.23;
            // b = 1.23;
            // c = 10;
            // d = (double)c;
            // Console.WriteLine("a={0} b={1} c={2} d={3}",a,b,c,d);

            // 文字列の変数について理解
            // string str1, str2;
            // Console.Write("str1=");
            // str1 = Console.ReadLine();
            // Console.Write("str2=");
            // str2 = Console.ReadLine();
            // Console.WriteLine("str1 + str2 = {0}", str1 + str2);

            //定数について理解
            const int NUMBER = 100;
            const string STRING = "Hoge";
            Console.WriteLine(NUMBER);
            Console.WriteLine(STRING);
            // NUMBER = 100;
            // STRING = "fuga";
        }
    }
}