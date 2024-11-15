using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1_08._11._2024_elenco_voti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Scrivi un algoritmo che permette di inserire un elenco di 
             * voti (con valore da 1 a 10) terminato da un numero negativo 
             * e determina se lo studente ha raggiunto una media di almeno 
             * 6 informandolo di conseguenza sull'esito dell'A.S
             */

            double voto; //variabile che utilizzo per chiedere il voto
            double sommaVoti = 0; //variabile che contiene la somma dei voti
            int contaVoti = 0; //conta il numero di voti inseriti
            double media; //variabile che utilizzeremo per il calcolo della media

            do
            {
                Console.WriteLine("Inserisci un voto da 1 a 10");
                voto = Convert.ToDouble(Console.ReadLine()); //leggi il voto
                if (voto>=1&&voto<=10)
                {
                    sommaVoti = sommaVoti + voto; //aumenta la somma dei voti
                    contaVoti++; //incrementa i voti validi
                }
            } while (voto >= 0)
            ; //usciamo dal ciclo con inserimento di numero negativo

            media = sommaVoti / contaVoti; //calcolo la media
            if (media>=6) {
                Console.WriteLine("Complimenti sei stato promosso con la media del " + media);
            }
            else
            {
                Console.WriteLine("Peccato non sei stato promosso");
            }
            Console.ReadKey();
        }
    }
}
