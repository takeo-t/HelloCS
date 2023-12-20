class Program
{
    static void Main()
    {
        // Personクラスのインスタンスを生成
        Person person1 = new Person("山田太郎", 30);

        //メソッドの呼び出し
        person1.Introduce();

        //別のインスタンスを生成
        Person person2 = new Person("佐藤花子", 25);
        person2.Introduce();
    }
}