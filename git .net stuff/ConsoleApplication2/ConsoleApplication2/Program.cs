using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class MyClass
    {
        public int val = 20;
    }
    class Program
    {
        static void MyMethod(ref MyClass f1, ref int f2)
        {
            f1.val+=5;
            f2+=5;
        }
        static void Main()
        {
            MyClass A1 = new MyClass();
            int A2 = 10;
            MyMethod(ref A1, ref A2);
            Console.WriteLine("A1={0} si A2={1} ", A1.val, A2);
        }
    }
}
