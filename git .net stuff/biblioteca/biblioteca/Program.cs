using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Biblioteca
    {
        public int termen_imprumut = 30;
        public int data_imprumut_zi;
        public int data_imprumut_luna;
        public int data_returnarii_zi;
        public int data_returnarii_luna;
        public int data_curenta_zi;
        public int data_curenta_luna;

    }
    class Carte:Biblioteca
    {
        public string nume_autor="daniel sollis";
        public string titlu_carte="illustrated c# 2012";
    }
    class Articol:Biblioteca
    {
        public string nume_autor="vasile";
        public string nume_articol="poezii";
    }
    class Cititor_Carte:Carte
    {
        public string nume_cit_carte="Arnold";

        public void Daysleft(int x, int y)
        {
            int z;
            if (data_curenta_zi < data_imprumut_zi) z = data_imprumut_zi - data_curenta_zi;
            else z = data_curenta_zi - data_imprumut_zi;
            Console.WriteLine("Zile ramase:{0}",z);
        }
    }
    class Cititor_Articol:Articol
    {
        public string nume_cit_art="Schwarzenegger";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cititor_Carte ob1 = new Cititor_Carte();

            Console.WriteLine("{0} a imprumutat {1} de {2}",ob1.nume_cit_carte, ob1.titlu_carte, ob1.nume_autor);

            Console.Write("zi imprumut(imprumutul e de 30 zile)");
            ob1.data_imprumut_zi = int.Parse(Console.ReadLine());
            Console.Write("luna imprumut");
            ob1.data_imprumut_luna = int.Parse(Console.ReadLine());

            Console.Write("Zi curenta(<30):");
            ob1.data_curenta_zi = int.Parse(Console.ReadLine());
            Console.Write("Luna curenta(<12):");
            ob1.data_curenta_luna = int.Parse(Console.ReadLine());

            ob1.Daysleft(ob1.data_imprumut_zi, ob1.data_curenta_zi);

        }
    }
}
