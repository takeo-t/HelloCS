// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
// namespace Sample601
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person p1, p2;
//             p1 = new Person(); //一つ目のPersonクラスのメソッドのインスタンスを生成
//             p2 = new Person(); //二つ目のPersonクラスのメソッドのインスタンスを生成
//             p1.name = "のぞみ";//フィールドnameに値を代入
//             p1.age = 22;//フィールドageに値を代入
//             p2.SetAgeAndName("こだま",23);//setAgeAndName()メソッドで、nameとageを設定
//             //showAgeAndName()メソッドで、それぞれのインスタンスのnameとageを表示
//             p1.ShowAgeAndName();
//             p2.ShowAgeAndName();
//         }
//     }
// }

namespace Sample602
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;
            int ans1 = calc.Add(a, b);
            int ans2 = calc.Add(a, b, c);
            Console.WriteLine("{0} + {1} = {2}", a, b, ans1);
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, ans2);
        }
    }
}