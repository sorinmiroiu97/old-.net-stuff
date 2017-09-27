using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplul4
{
    class BaseClass
    {
        public virtual void MethodX()
        {
            Console.WriteLine("This is MethodX of the BaseClass ");
        }
    }
    class DerivedClass:BaseClass
    {
        public override void MethodX()
        {
            Console.WriteLine("This is MethodX of the DerivedClass ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass(); //BaseClass reference and object
            BaseClass obj2 = new DerivedClass(); //BaseClass object with Derived Class reference

            obj1.MethodX();
            obj2.MethodX();
        }
    }
}
