namespace SampleEx301
{
    // calculatorクラスを継承したExCalculatorクラス
    class ExCalculator : Calculator
    {
        //掛け算
        public void mul()
        {
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
        }
        //割り算
        public void div()
        {
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}