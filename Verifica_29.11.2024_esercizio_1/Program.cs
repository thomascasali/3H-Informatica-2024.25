/*
 Sviluppare un algoritmo in codice C# con le seguenti funzionalità:
riempie un vettore di N (N deve essere un numero pari) di interi positivi casuali
calcola la somma dei valori di posto pari e dei valori di posto dispari (0 lo consideriamo pari, per cui faremo la somma dei posti 0,2,4,6 etc… e dei posti 1,3,5,...)
confronta la somma dei termini posto pari con quella dei termini di posto dispari
stampa la somma dei termini di posto maggiore informando l’utente se è la somma dei posti pari o dei posti dispari
 */

//lettura dimensione del vettore
int n;
do
{
    Console.WriteLine("Inserisci un numero pari");
    n=Convert.ToInt32(Console.ReadLine());
    if (n % 2 != 0) Console.WriteLine("Il numero inserito non va bene perché è dispari");
} while (n%2!=0);

//dichiarazione e estrazione
var vettore = new int[n];
Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    vettore[i] = rnd.Next(1,100);
}

//sommo le posizioni pari e le posizioni dispari del vettore
int sommaPari = 0, sommaDispari = 0;
for (int i = 0; i < n; i++)
{
    if (i % 2 != 0)
    {
        sommaDispari += vettore[i];
    }
    else
    {
        sommaPari += vettore[i];
    }
}

//confronta e stampa
if (sommaPari > sommaDispari)
{
    Console.WriteLine("La somma dei posti pari è maggiore della somma dei posti dispari");
}
else if (sommaPari < sommaDispari)
{
    Console.WriteLine("La somma dei posti dispari è maggiore della somma dei posti pari");
}
else
{
    Console.WriteLine("La somma dei posti dispari è uguale alla somma dei posti pari");
}
Console.WriteLine("Somma dei posti pari:" + sommaPari);
Console.WriteLine("Somma dei posti dispari:" + sommaDispari);
