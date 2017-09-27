using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class SimpProp
    {
        int prop;
        public SimpProp()
        {
            prop = 0;
        }
        public int MyProp
        {
            get {
                return prop;
                }
            set {
                if (value >= 0) prop = value;
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpProp ob= new SimpProp();
            Console.WriteLine("Valoarea originala a lui ob.MyProp: ", ob.MyProp);
            ob.MyProp=100; //atribuirea unei val
            Console.WriteLine("valoarea lui ob.MyProp: " + ob.MyProp); 
            //atribuirea unei valori negative !
            Console.WriteLine("Incercare de atribuire -10 la ob.MyProp ");
            ob.MyProp=-10;
            Console.WriteLine("valoarea lui ob.MyProp: " + ob.MyProp);
        }
    }
}
