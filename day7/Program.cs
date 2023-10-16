// namespace Sample701
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person p1,p2;
//             p1 = new Person();       //  一つ目のPersonクラスのメソッドのインスタンスを生成
//             p2 = new Person();       //  二つ目のPersonクラスのメソッドのインスタンスを生成
//             p1.Name = "山田太郎";    //  フィールドnameに値を代入
//             p1.Age = 19;             //  フィールドageに値を代入
//             p2.SetAgeAndName("佐藤花子", 23);   //  setAgeAndName()メソッドで、nameとageを設定
//             p1.ShowAgeAndName();     //  メソッドから、名前と年齢を表示
//             //  プロパティから名前と年齢を表示
//             Console.WriteLine("名前：{0} 年齢：{1}", p2.Name, p2.Age);
//         }
//     }
// }

// namespace Sample703
// {
//        class Person2
//        {
//            //  情報の設定
//            public void SetAgeAndName(string name, int age)
//            {
//                Name = name;
//                Age = age;
//            }
//            //  情報の表示（メソッド）
//            public void ShowAgeAndName()
//            {
//                Console.WriteLine("名前：{0} 年齢：{1}", Name, Age);
//            }
//            //  情報の設定
//            public string Name
//            {
//                private set; get;
//            }
//            //  情報の設定
//            public int Age
//            {
//                set; get;
//            }
//        }
// }

// //prob7-1

// namespace Problem7_1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Data d = new Data();
//             d.Number = 100; //public int Numberにアクセス
//             d.Comment = "Programming C#"; //public string Commentにアクセス
//             d.DisplayData();
//         }
//     }
// }

// //prob7-2

// namespace Problem7_2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             TwoStrings s = new TwoStrings();
//             s.String1 = "Hello";
//             s.String2 = "World";
//             Console.WriteLine("一つ目の文字列は" + s.String1);
//             Console.WriteLine("二つ目の文字列は" + s.String2);
//             Console.WriteLine("二つの文字列を合成したものは" + s.GetConnectedString());
//         }
//     }
// }

//prob7-3
namespace problem7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.Number1 = 8;
            c.Number2 = 9;
            Console.WriteLine("{0} + {1} + {2}",c.Number1,c.Number2,c.Add());
            Console.WriteLine("{0} - {1} = {2}",c.Number1,c.Number2,c.Sub());
        }
    }
}