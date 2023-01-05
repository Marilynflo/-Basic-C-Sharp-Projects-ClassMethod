using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassMethod
{
    public class Class1
    {
        public void MathMethod1(int num1, int num2) //creating a class with void method
        {
            int result = num1 / 2;
            int result2 = num2 / 2;
            Console.WriteLine("Your number divided by 2 = " + result2);

        }

        public void MathMethod2(int num3, int num) //overloading method
        {
            int result5 = num3 * num;
            Console.WriteLine(num3 + " x " + num + " = " + result5);
        }

        public static int MathMethod2(int num1, out int num2) //declaring class to be static
        {
            num2 = num1 + 18;
            return num2;

        }
    }
}