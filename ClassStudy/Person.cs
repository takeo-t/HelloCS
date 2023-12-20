class Person
{
    //プロパティの定義
    public string Name { get; set; }
    public int Age { get; set; }
    //コンストラクタ
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    //メソッドの定義
    public void Introduce()
    {
        Console.WriteLine($"こんにちは、私の名前は{Name}、年齢は{Age}歳です。");
    }
}