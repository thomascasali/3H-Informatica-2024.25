using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondoProgettoInformatica3H
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n; //dichiarazione
            n=Convert.ToInt32(Console.ReadLine()); //assegnazione
            int m = int.Parse( Console.ReadLine());

            //ciclo che conta fino a 10 
            for (; n <= m; )
            {
                Console.WriteLine(n);
                n = n + 2;
            }
            Console.ReadKey();
     
        }
    }
}
