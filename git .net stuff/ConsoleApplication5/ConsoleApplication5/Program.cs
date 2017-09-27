using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Persoana
    {
        public string nume;
        public int varsta;
        public Persoana()
        {
            nume = "Dan";
            varsta = 10;
        }
        public Persoana(string a)
        {
            nume = a;
        }
        public Persoana(string a, int b)
        {
            nume = a;
            varsta = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persoana o = new Persoana();
            Console.WriteLine(o.nume+o.varsta);
            Persoana o1 = new Persoana("Ion");
            Console.WriteLine(o1.nume);
            Persoana o2 = new Persoana("Maria", 20);
            Console.WriteLine(o2.nume + o2.varsta);
        }
    }
}
