namespace problem7_3
{
    class Calculation
    {
        private int number1;
        private int number2;

        public int Number1
        {
            set { number1 = value; }
            get { return number1; }
        }
        
        public int Number2
        {
            set { number2 = value; }
            get { return number2; }
        }

        public int Add()
        {
            return Number1 + Number2;
        }

        public int Sub()
        {
            return Number1 - Number2;
        }
    }
}