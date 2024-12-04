/*
Sviluppare un algoritmo in codice C# con le seguenti funzionalità:
estrazione in modo casuale due vettori da 50 numeri interi compresi tra 1 e 99. 
riempimento di un terzo vettore assegnando ad ogni suo elemento il massimo fra i corrispondenti elementi dei primi due vettori. (es. se v1[0]=1 e v2[0]=5 allora v3[0]=5) 
Stampa dei tre vettori.
*/

//dichiarazione e istanziazione delle variabili
int dimensione = 50; //dimensione del vettore (non necessaria)
var vet1 = new int[dimensione];
var vet2 = new int[dimensione];
var vet3 = new int[dimensione];
Random rnd = new Random();

//riempimento dei 2 vettori
for (int i = 0; i < dimensione; i++)
{
    vet1[i] = rnd.Next(1, 100);
    vet2[i] = rnd.Next(1, 100);
}

//caricamento del terzo vettore (operazione che potrebbe essere fatta anche nel ciclo precedente
for (int i = 0; i < dimensione; i++)
{
    if (vet1[i] < vet2[i])
    {
        vet3[i] = vet2[i];
    }
    else
    {
        vet3[i] = vet1[i];
    }
}

//stampe
Console.WriteLine("Vettore 1:");
for (int i = 0; i < dimensione; i++) Console.Write(vet1[i] + " ");
Console.WriteLine("");
Console.WriteLine("Vettore 2:"); 
for (int i = 0; i < dimensione; i++) Console.Write(vet2[i] + " ");
Console.WriteLine(""); 
Console.WriteLine("Vettore contenente il massimo:");
for (int i = 0; i < dimensione; i++) Console.Write(vet3[i] + " ");
