﻿// namespace Sample701
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

//prob7-1

namespace Problem7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            d.Number = 100; //public int Numberにアクセス
            d.Comment = "Programming C#"; //public string Commentにアクセス
            d.DisplayData();
        }
    }
}