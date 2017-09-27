using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplul3
{
    class Overloading
    {
        public void method(String s, int x)
        {
            Console.WriteLine("This is the first definition of the method");
        }
        public void method(int x, String s)
        {
            Console.WriteLine("This is the second definition of the method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overloading obj = new Overloading();

            obj.method("anything", 20);
            obj.method(100, "something else");

        }
    }
}
