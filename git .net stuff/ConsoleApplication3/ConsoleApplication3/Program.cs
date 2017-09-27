using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class MyClass
    {
        public int val = 20;
    }
    class Program
    {
        static void MyMethod(out MyClass f1, out int f2, out int f3)
        {
            f1=new MyClass(); //cearea unui obiect al clasei
            f1.val = 25;
            //f2=f2+5; EROARE!
            f2=15;
            //EROARE! param f3 nu este initializat
            f3=100; //acum param f3 e init.
        }
        static void Main()
        {
            MyClass A1 = null;
            int A2, A3;
            MyMethod(out A1, out A2, out A3); //apelul metodei
            Console.WriteLine("A1={0} A2={1} A3={2}",  A1.val,  A2,  A3);
        }
    }
}
