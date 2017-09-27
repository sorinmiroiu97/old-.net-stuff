using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Dreptunghi
    {
        int l1, l2;
        string culoare;
        public Dreptunghi()
        {
            l1 = 0;
            l2 = 0;
            //culoare = "";
        }
        public int Dreptl1
        {
            get {
                return l1;
                }
            set {
                if (value >= 0) l1 = value;
                }
        }
        public int Dreptl2
        {
            get {
                return l2;
                }
            set {
                if (value >= 0) l2 = value;
                }
            
        }
        public string Dreptculoare
        {
            get
            {
                return culoare;
            }
            set
            {
                culoare = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dreptunghi ob = new Dreptunghi();
            Console.WriteLine("lat1={0} , lat2={1} , culoarea={2} ", ob.Dreptl1, ob.Dreptl2, ob.Dreptculoare);
            Console.Write("lat1= ");
            ob.Dreptl1 = int.Parse(Console.ReadLine());
            Console.Write("lat2= ");
            ob.Dreptl2 = int.Parse(Console.ReadLine());
            Console.Write("culoare= ");
            ob.Dreptculoare = Console.ReadLine();
            Console.WriteLine("lat1 "+ob.Dreptl1+" lat2 "+ob.Dreptl2+" culoare "+ob.Dreptculoare);
        }
    }
}
