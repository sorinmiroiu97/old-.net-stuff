using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class FormeGeometrice
    {
        public string nume_forma;
        public string culoare;
        public void Color()
        {
            Console.WriteLine(culoare);
        }
        public void Nume()
        {
            Console.WriteLine(nume_forma);
        }
    }
    class Patrat : FormeGeometrice
    {
        public int latura=15;
        public float Aria(int a)
        {
            return a * a;
        }
    }
    class Triunghi : FormeGeometrice
    {
        public int baza=3, h=6;
        public float Aria(int a, int b)
        {
            return (a * b) / 2;
        }
    }
    class Dreptunghi : FormeGeometrice
    {
        public int l1=54, l2=23;
        public float Aria(int a, int b)
        {
            return a * b;
        }
    }
    class Romb : FormeGeometrice
    {
        public int lat=15, h=4;
        public float Aria(int a, int b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Patrat pt = new Patrat();
            Triunghi tr = new Triunghi();
            Dreptunghi dr = new Dreptunghi();
            Romb rb = new Romb();

            pt.nume_forma = "patrat";
            pt.culoare = "maro";

            tr.nume_forma = "triunghi";
            tr.culoare = "negru";

            dr.nume_forma = "dreptunghi";
            dr.culoare = "alb";

            rb.nume_forma = "romb";
            rb.culoare = "rosu";

            pt.Color();
            pt.Nume();
            Console.WriteLine("arie patrat {0} ", pt.Aria(pt.latura));

            tr.Color();
            tr.Nume();
            Console.WriteLine("arie patrat {0} ", tr.Aria(tr.baza, tr.h));

            dr.Color();
            dr.Nume();
            Console.WriteLine("arie patrat {0} ", dr.Aria(dr.l1, dr.l2));

            rb.Color();
            rb.Nume();
            Console.WriteLine("arie patrat {0} ", rb.Aria(rb.lat, rb.h));
        }
    }
}
