using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masina
{
    class Car
    {
        public string marca;
        public int locuri;
        public int consum;
    }
    class fiat:Car
    {
        public fiat()
        {
            locuri = 0;
            consum = 3;
        }
        public float timp(int d, int v)
        {
            float t;
            t = d / v;
            return t;
        }
        public float consumul(int d)
        {
            float c;
            c = (consum * d) / 100;
            return c;
        }
    }
    class bambeu:Car
    {
        public bambeu()
        {
            locuri = 0;
            consum = 20;
        }
        public float timp(int d, int v)
        {
            float t;
            t = d / v;
            return t;
        }
        public float consumul(int d)
        {
            float c;
            c = (consum * d) / 100;
            return c;
        }
    }
    class VW:Car
    {
        public VW()
        {
            locuri = 0;
            consum = 99;
        }
        public float timp(int d, int v)
        {
            float t;
            t = d / v;
            return t;
        }
        public float consumul(int d)
        {
            float c;
            c = (consum * d) / 100;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            fiat ob1 = new fiat();
            bambeu ob2 = new bambeu();
            VW ob3 = new VW();
            ob1.marca = "fiat";
            ob2.marca = "bambeu";
            ob3.marca = "arnold schwartzeneger-chopper!!!";
            ob1.locuri = 2;
            ob2.locuri = 4;
            ob3.locuri = 99;
            Console.WriteLine("marca1={0} marca2={1} marca3={2}",ob1.marca, ob2.marca, ob3.marca);
            Console.WriteLine("marca1={0} marca2={1} marca3={2}", ob1.locuri, ob2.locuri, ob3.locuri);
            Console.WriteLine("fiatului ii ia {0} (ore) si consuma {1}", ob1.timp(234, 55), ob1.consumul(234));
            Console.WriteLine("bambeului ii ia {0} (ore) si consuma {1}", ob2.timp(234, 100), ob2.consumul(234));
            Console.WriteLine("lui arnold(VW) ii ia {0} (ore) si consuma {1}", ob3.timp(234, 169), ob3.consumul(234));
        }
    }
}
