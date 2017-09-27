using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Demo
    {
        public int Suma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public void Adunare(int a, int b)
        {
            int s = a + b;
            Console.WriteLine("suma este {0}", s);
        }
    }

    class MyClass
    {
        public int Sum(int x, int y) //Declararea metodei
        {
            return x + y; //returneaza suma
        }
        public float Avg(float Input1, float Input2) //Declararea metodei
        {
            return (Input1 + Input2) / 2.0F; //returneaza media
        }
    }

    class Class1
    {
        static void Main()
        {
            MyClass o = new MyClass();
            int SomeInt = 6;
            Console.WriteLine("Sum:{0} and {1} is {2}",5,SomeInt,o.Sum(5,SomeInt)); //Invocarea metodei
                                                                      // 5, SomeInt - param. actuali
            Console.WriteLine("Avg:{0} and {1} is {2}",5,SomeInt, o.Avg(5,SomeInt)); //Invocarea metodei
                                                                      // 5, SomeInt - param. actuali
        }
    }

   /* class Program
    {
        static void Main(string[] args)
        {
            /*      //CLASA DEMO
             
            int a, b;
            Demo ob1 = new Demo();
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            ob1.Adunare(a, b);
            int s = ob1.Suma(a, b);
            Console.WriteLine("suma e {0}", s);
             

        }
    }
     */
}
