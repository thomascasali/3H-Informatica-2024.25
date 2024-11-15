using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lancio_del_dado_con_vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lanci;
            var dado = new int[7];
            // int[] dado = new int[7]; questa dichiarazione è equivalente alla precedente
            var rand = new Random();
            int facciaEstratta;
            int facciaMax = 1;

            do
            {
                Console.WriteLine("Inserisci il numero di lanci che vuoi fare:");
                lanci = Convert.ToInt32(Console.ReadLine());
            } while (lanci < 1);

            for (int i = 0; i < lanci; i++)
            {
                facciaEstratta = rand.Next(1, 7);
                dado[facciaEstratta]++;
            }

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("La faccia " + i + " è stata estratta " + dado[i] + " volte");
                if (dado[facciaMax] < dado[i]) facciaMax = i;
            }

            Console.WriteLine("La faccia estratta di più è la " + facciaMax);

            Console.ReadKey();
        }
    }
}
