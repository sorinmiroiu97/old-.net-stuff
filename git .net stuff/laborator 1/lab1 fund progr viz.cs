using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Medie
    {
        public string nume;
        public int nota1, nota2, nota3;
        public float medie(int a, int b, int c)
        {
            int s;
            s = a + b + c;
        float m = s / 3;
        return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Medie ob1 = new Medie();
            Medie ob2 = new Medie();
            Medie ob3 = new Medie();

            ob1.nume = Console.ReadLine();
            ob1.nota1 = int.Parse(Console.ReadLine());
            ob1.nota2 = int.Parse(Console.ReadLine());
            ob1.nota3 = int.Parse(Console.ReadLine());
            float med1 = ob1.medie(ob1.nota1, ob1.nota2, ob1.nota3);
            Console.WriteLine("Media este {0}", med1);

            ob2.nume = Console.ReadLine();
            ob2.nota1 = int.Parse(Console.ReadLine());
            ob2.nota2 = int.Parse(Console.ReadLine());
            ob2.nota3 = int.Parse(Console.ReadLine());
            float med2 = ob2.medie(ob2.nota1, ob2.nota2, ob2.nota3);
            Console.WriteLine("Media este {0}", med2);

            ob3.nume = Console.ReadLine();
            ob3.nota1 = int.Parse(Console.ReadLine());
            ob3.nota2 = int.Parse(Console.ReadLine());
            ob3.nota3 = int.Parse(Console.ReadLine());
            float med3 = ob3.medie(ob3.nota1, ob3.nota2, ob3.nota3);
            Console.WriteLine("Media este {0}", med3);
        }
    }
}
