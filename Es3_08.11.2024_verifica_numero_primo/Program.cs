using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3_08._11._2024_verifica_numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrivi un algoritmo che chiede all'utente di inserire un numero 
             intero positivo e verifica se è un numero primo.
            */

            int numero; //numero da varificare
            int divisibile = 0;

            do
            {
                Console.WriteLine("Inserisci il numero da verificare:");
                numero = Convert.ToInt32(Console.ReadLine()); //legge il numero da tastiera
            } while (numero < 0);

            for (int divisore=2; divisore<numero/2+1; divisore++)
            {
                if (numero%divisore==0) //se questa condizione è vera il numero non è primo
                {
                    divisibile++;
                }
            }

            if (divisibile==0)
            {
                //il numero è primo perché non ho trovato nessun divisore
                Console.WriteLine("Il numero è primo");
            }
            else
            {
                Console.WriteLine("Il numero NON è primo, ho trovato "+ divisibile +" divisori");

            }
            Console.ReadKey();
        }
    }
}
