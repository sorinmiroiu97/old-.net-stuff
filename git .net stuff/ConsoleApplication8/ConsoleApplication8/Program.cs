using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class SomeClass //base class
    {
        public string Field1 = "base class field";
        public void Method1(string value)
        {
            Console.WriteLine("base class__method1:{0}",value);
        }
    }
    class Otherclass : SomeClass //derived class
    {
        public string Field2 = "derived class field";
        public void Method2(string value)
        {
            Console.WriteLine("derived class__method2:{0}", value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Otherclass oc = new Otherclass();
            oc.Method1(oc.Field1);
            oc.Method1(oc.Field2);
            oc.Method2(oc.Field1);
            oc.Method2(oc.Field2);
        }
    }
}
