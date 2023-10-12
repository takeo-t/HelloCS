using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(123);
            // Console.WriteLine(456);
            // Console.WriteLine("123");
            // Console.WriteLine("{0} * {1} = {2}",10, 3, 10 * 3);
            int a;
            int b = 3;
            int add,sub;
            double avg;
            a = 6;
            add = a + b;
            sub = a - b;
            avg = (a + b) / 2.0;
            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);
        }
    }
}