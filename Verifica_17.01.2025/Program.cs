//main

//dichiarazioni
var vet = new int[10];
var vetInvertito = new int[10];
var rnd = new Random();
int aux; //variabile ausiliaria 

for (int i = 0; i < vet.Length; i++)
{
    vet[i] = rnd.Next(1, 100);
}

StampaVettore(vet);

//stampo il valore minore all'interno del vettore
Console.WriteLine("Il valore minore è nella posizione: " + MinVettore(vet) + "\n");

//stampo la media del vettore
Console.WriteLine("La media dei numeri del vettore è: " + MediaVettore(vet) + "\n");

//cerco un numero nel vettore
aux = CercaPosNumVettore(vet, 20);
if (aux>=0)
{
    Console.WriteLine("Il numero cercato (20) è presente nella posizione: " + aux +"\n");
}
else
{
    Console.WriteLine("Il numero cercato (20) non è presente nel vettore\n");
}

//inverto il vettore e lo stampo
vetInvertito = InvertiVettore(vet);
StampaVettore(vetInvertito);


//inizio metodi
void StampaVettore(int[] v)
{
    for (int i = 0; i < v.Length; i++)
    {
        Console.Write(v[i]+" ");
    }
    Console.WriteLine("\n");
}
int MinVettore(int[] v)
{
    int numMin = v[0], indexMin = 0;

    for (int i = 1; i < v.Length; i++)
    {
        if (v[i] < numMin)
        {
            numMin  = v[i]; //memorizzo il numero minore
            indexMin = i; //memorizzo la sua posizione
        }
    }
    return indexMin+1; //ritorno la posizione del numero con +1 
}

double MediaVettore(int[] v)
{
    double sommaVet = 0;

    for (int i = 0; i < v.Length; i++)
    {
        sommaVet += v[i]; //sommo tutti i numeri presenti nel vettore
    }

    return sommaVet / v.Length; //ritorno la media
}

int CercaPosNumVettore(int[] v, int n)
{
    for (int i = 0; i < v.Length; i++)
    {
        if (v[i] == n)
        {
            return i; //ho trovato il numero esco dal metodo con l'indice del numero
        }
    }
    return -1; //non ho trovato il numero, esco con -1
}

int[] InvertiVettore(int[] v)
{
    int mezzo = v.Length / 2; //non necessaria ma utilizzata per far capire meglio il funzionamento
    int dim = v.Length-1; //ultimo indice del vettore 
    int temp;

    for (int i = 0; i < mezzo; i++) //mi basta arrivare a metà del vettore
    {
        temp = v[i];
        v[i] = v[dim-i]; //dim-i mi permette di scorrere il vettore all'indietro
        v[dim-i] = temp;
    }

    return v; //ritorno l'intero vettore invertito
}