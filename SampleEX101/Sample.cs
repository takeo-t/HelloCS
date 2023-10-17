// namespace Problemex1_1
// {
//     class Sample
//     {
//         public Sample()
//         {
//             Console.WriteLine("コンストラクタ");
//         }
//         public void foo()
//         {
//             Console.WriteLine("foo");
//         }
//     }
// }

//prob1-3

namespace Problemex1_3
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }
        public void func()
        {
            Console.WriteLine("func");
        }

        ~Sample()
        {
            Console.WriteLine("エンド");
        }
    }
}