using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primoProgetto3H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ciao");
            Console.WriteLine("Inserisci la tua età");
            string eta = Console.ReadLine();
            Console.WriteLine("Hai inserito: " + eta);
            //controlla se l'età è maggiore di 18
            if (int.Parse(eta) >= 18)
            {
                Console.WriteLine("Sei maggiorenne");
            }
            else
            {
                Console.WriteLine("Sei minorenne");
            }
            Console.ReadKey();

            //chiedi l'inserimento di un numero tra 5 e 15
            Console.WriteLine("Inserisci un numero tra 5 e 15");
            string numero = Console.ReadLine();
            int num = int.Parse(numero);
            if (num >= 5 && num <= 15)
            {
                Console.WriteLine("Hai inserito un numero corretto");
            }
            else
            {
                Console.WriteLine("Hai inserito un numero sbagliato");
            }
        }
    }
}
