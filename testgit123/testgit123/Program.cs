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
            Titel("Dies ist ein Test",ConsoleColor.Green);

            Console.WriteLine("TESTMERGLER");
            string binZahl = Binaerzahleinlesen();
            Console.ReadKey();

        }
        /// <summary>
        /// Bit einen Text formatiert als Text aus
        /// </summary>
        /// <param name="titel">Text der augegeben werden soll</param>
        /// <param name="textfarbe">ConsolColor TextFarbe des Titels</param>
        static void Titel(string titel, ConsoleColor textfarbe)
        {
            int breite = Console.WindowWidth;
            int textlengh = titel.Length;
            ConsoleColor aktTextFarbe = Console.ForegroundColor; //aktuelle Farbe speichern

            Console.Clear();
            Console.ForegroundColor = textfarbe;
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

            Console.ForegroundColor = aktTextFarbe;
        }

        /// <summary>
        /// Einlesen einer Binärzahl 
        /// </summary>
        /// <returns>String mit nur Nullen und Einsen</returns>
        static string Binaerzahleinlesen()
        {
            Console.WriteLine("Bitte hier die Biärzahl eingeben (0/1): ");
            string input = Console.ReadLine();
            return input; 
        }
    }
}
