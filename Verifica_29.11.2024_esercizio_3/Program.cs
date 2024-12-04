/*
Sviluppare un algoritmo in codice C# con le seguenti funzionalità:
- dichiarare un vettore (vet) di interi di dimensione massima 100 posti
- chiede all'utente quante posizioni del vettore riempire (numero da 1 a 100)
- chiede all'utente due numeri n e m (con m>n) che rappresentano gli estremi di numeri casuali con i quali riempire le posizioni del vettore precedentemente definito
- stampa il vettore
- chiede all'utente un numero x compreso tra n ed m
- riempie due vettori vmin e vmax, rispettivamente con tutti i valori minori di x e maggiori o uguali a x.
- stampa il contenuto dei due vettori così calcolati
- stampa la media dei valori contenuti nei vettori vmin e vmax
 */

//dichiarazione delle variabili
var vet = new int[100];
var vmin = new int[100];
var vmax = new int[100];
int imin = 0, imax = 0;
int sommaMin = 0, sommaMax = 0;
double mediaMin, mediaMax;
int posizioni;
int n, m; //estremi dell'intervallo di numeri casuali
int x; //numero che fungerà da separatore
Random rnd = new Random();

//richiesta di inserimento del numero di valori da inserire e dell'intervallo di numeri da estrarre
Console.WriteLine("Inserisci il numero di numeri da inserire nel vettore (da 1 a 100):");
do
{
    posizioni = Convert.ToInt32(Console.ReadLine());
    if (posizioni < 1 || posizioni > 100) Console.WriteLine("Numero inserito errato. Inserisci un numero da 1 a 100:");
} while (posizioni < 1 || posizioni > 100);

//leggo n
Console.WriteLine("Inserisci un numero che rappresenta l'estremo inferiore dei valori casuali estratti:");
n= Convert.ToInt32(Console.ReadLine());

//adesso leggo m e verifico che sia maggiore di n
Console.WriteLine("Inserisci un numero che rappresenta l'estremo superiore dei valori casuali estratti:");
do
{
    m = Convert.ToInt32(Console.ReadLine());
    if (m <= n) Console.WriteLine("Numero inserito errato. Inserisci un numero maggiore di " + n);
} while (m <= n);


//riempimento del vettore
for (int i = 0; i < posizioni; i++)
{
    vet[i] = rnd.Next(n, m);
}

//stampa del vettore
for (int i = 0; i < posizioni; i++)
{
    Console.Write(vet[i] + " ");
}
Console.WriteLine("");

//chiede all'utente un numero x compreso tra n e m
Console.WriteLine("Inserisci un numero x compreso tra "+ n +" e " + m + " :");
do
{
    x = Convert.ToInt32(Console.ReadLine());
    if (x < n || x>m) Console.WriteLine("Numero inserito errato: inserisci un numero compreso tra " + n + " e " + m);
} while (x < n || x > m);

//valorizzo i vettori vmin e vmax
for (int i=0;i<posizioni;i++)
{
    if (vet[i]<x)
    {
        vmin[imin] = vet[i];
        imin++;
    }
    else
    {
        vmax[imax] = vet[i];
        imax++;
    }
}

//stampo vmin
for (int i = 0; i < imin; i++)
{
    Console.Write(vmin[i] + " ");
    sommaMin += vmin[i];
}
Console.WriteLine("");

//stampo vmax
for (int i = 0; i < imax; i++)
{
    Console.Write(vmax[i] + " ");
    sommaMax += vmax[i];
}
Console.WriteLine("");

//calcolo e stampa della media
mediaMin = (double)sommaMin / imin;
mediaMax = (double)sommaMax / imax;
Console.WriteLine("La media del vettore dei minimi è " + mediaMin);
Console.WriteLine("La media del vettore dei massimi è " + mediaMax);


