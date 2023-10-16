namespace Problem7_1
{
    class Data //Dataという設計図
    {
        //番号(フィールド）
        private int number = 0;
        //コメント（フィールド）
        private string comment = "";
        
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Comment
        {
            get {return comment; }
            set { comment = value; }
        }
        public void DisplayData()
        {
            Console.WriteLine("Number: " + Number);
            Console.WriteLine("Comment: " + Comment);
        }
    }
}