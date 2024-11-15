using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES1_Verifiica_11._10._2024
{
    internal class Program
    {
        /*
        Chiedere all'utente di inserire una serie di numeri interi positivi 
        (terminando con uno zero) e calcolare la media dei numeri inseriti. 
        Stampare quanti numeri sono stati inseriti, la loro somma e la 
        media risultante
        */
        static void Main(string[] args)
        {
            //dichiarazione delle variabili
            double media;
            int somma, qta, numero; 

            //inizializzazione variabili
            somma=0;
            qta=0;

            do
            {
                qta++;
                do
                {
                    Console.WriteLine("Inserisci il " + qta + "° numero");
                    numero = Convert.ToInt32(Console.ReadLine()); //leggo il numero
                } while (numero < 0);
                if (numero == 0) qta--; //se il numero è 0 decremento la qta
                somma = somma + numero; //aggiungo il numero alla somma
            } while (numero != 0);
            if (qta>0)
            {
                //calcolo la media e la stampo
                media = (double)somma / qta;
                Console.WriteLine("La somma è " + somma);
                Console.WriteLine("La quantità di numeri inseriti è " + qta);
                Console.WriteLine("La media è " + media);
            }
            else
            {
                Console.WriteLine("Non è stato inserito nessun numero intero positivo");
            }

            Console.ReadKey();
        }
    }
}
