using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//** Konvertierung in Zahlensysteme

namespace testgit
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Titel("Dies ist ein Test");
            Console.ReadKey();
        }

        static void Titel(string titel)
        {
            int breite = Console.WindowWidth;
            int textlengh = titel.Length;


            Console.Clear();

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < breite/2 - textlengh/2; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(titel);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }

    }
}
