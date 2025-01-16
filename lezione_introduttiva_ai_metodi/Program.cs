//metodi
void Stampa(string msg)
{
    Console.Write("Il messaggio ricevuto è: ");
    Console.WriteLine(msg);
    Console.WriteLine();
}

void Separatore()
{
    Console.WriteLine("***********************\n");
}

int Somma(int a, int b)
{
    return a + b;
}

void StampaVettore(int[] v)
{
    Console.WriteLine("Contenuto del vettore:");
    //stampo il vettore usando l'attributo length che mi restituisce la dimensione del vettore passato
    for (int i=0; i < v.Length; i++)
    {
        Console.Write(v[i] +" ");
    }
    Console.WriteLine();
}

//main
Stampa("Ciao, sto passando un parametro");
Separatore();
Stampa("Questa è la seconda riga");
Separatore();
Stampa("1");
Separatore();

//chiama la funzione somma e stampa il risultato
int ris = Somma(10, 7);
ris = Somma(10, 7);
Stampa(ris.ToString());
Separatore();

//dichiaro un vettore e lo stampo con un apposito metodo
int[] vettore = new int[] { 1, 2, 3, 4, 5, 6 , 7, 8, 9};
StampaVettore(vettore);
Separatore();
