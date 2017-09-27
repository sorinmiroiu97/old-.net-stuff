using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    //PROBLEMA 1
    class MyClass
    {
        public int Add(int a, int b)
        {
            return (a+b);
        }
        public string Add(string x, string y)
        {
            return (x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            int a = 10, b = 20;
            Console.WriteLine("a+b={0}",ob.Add(a,b));
            string x = "abc", y = "def";
            Console.WriteLine("x+y={0}",ob.Add(x,y));
        }
    }
}
