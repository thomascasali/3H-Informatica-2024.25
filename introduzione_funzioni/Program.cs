int[] v = new int[] { 1, 2, 3, 4, 5 };
Stampa("ciao");
int ris= Somma(5, 10);
Stampa(ris.ToString());
StampaVettore(v);
void Stampa(string msg)
{
    Console.WriteLine(msg);
}

int Somma(int a, int b)
{
    return a + b;
}

void StampaVettore(int[] vettore)
{
    for(int i =0; i < vettore.Length; i++)
    {
        Stampa(vettore[i].ToString());
    }
}