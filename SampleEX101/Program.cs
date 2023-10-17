// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// namespace SampleEx101
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person p1, p2;
//             p1 = new Person();  //  引数なしのコンストラクタ
//             p2 = new Person("太田隆", 29); //  引数ありのコンストラクタ
//             p1.Name = "斉藤花子";
//             p1.Age = 18;
//             p1.ShowAgeAndName();
//             p2.ShowAgeAndName();
//         }
//     }
// }

// //prob1-1
// namespace Problemex1_1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Sample s = new Sample();
//             s.foo();
//         }
//     }
// }

// //prob1-3

// namespace Problemex1_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Sample s = new Sample();
//             s.func();
//         }
//     }
// }

//prob1-2

namespace Problemex1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc(),c2 = new Calc(3,1);
            c1.Num1 = 1;
            c1.Num2 = 2;
            c1.ShowAdd();
            c2.ShowAdd();
        }
    }
}