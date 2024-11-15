using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2_08._11._2024_somma_dei_dispari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Scrivi un algoritmo che chiede all'utente di inserire una serie di N 
            (con N compreso tra 5 e 10) numeri interi e calcola la media aritmetica 
            dei SOLI numeri dispari inseriti (stampando anche qual è la loro somma 
            e la quantità).  
             */

            int n;
            double numero;
            double sommaDispari=0;
            int contaDispari = 0;
            double mediaDispari;

            do
            {
                Console.WriteLine("Inserisci un numero da 5 a 10");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 5 || n > 10);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numero = Convert.ToDouble(Console.ReadLine());
                if (numero%2==1)
                {
                    //se è vero allora il numero è dispari
                    sommaDispari = sommaDispari + numero;
                    contaDispari++;
                }
            }

            mediaDispari = sommaDispari / contaDispari;

            Console.WriteLine("La media dei numeri dispari inserita è " + mediaDispari);
            Console.WriteLine("La somma dei numeri dispari inserita è " + sommaDispari);
            Console.WriteLine("Il totale dei numeri dispari inseriti è " + contaDispari);

            Console.ReadKey();
        }
    }
}
