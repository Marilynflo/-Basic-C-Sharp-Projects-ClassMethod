using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: "); //asking for user input
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 19;
            int num3 = 50;
            int num = 10;

            Class1 FirstOp = new Class1(); //instantiating the class
            FirstOp.MathMethod1(num1, num2);
            FirstOp.MathMethod2(num3, num);

            Console.ReadLine();
        }
    }
}