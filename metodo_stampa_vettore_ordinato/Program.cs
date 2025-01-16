//main
int dim = 10; //dichiaro la dimensione del vettore
var vet = new int[dim]; //istanzio un vettore della dimensione dim
var rnd = new Random(); //istanzio l'oggetto Random

//faccio l'estrazione di un vettore casuale
for (int i = 0; i < dim; i++)
{
    vet[i] = rnd.Next(10, 100); //estraggo casualmente un numero da 10 a 99
}
//stampo il vettore generato
StampaVettore(vet);

//chiamo il metodo per ordinare il vettore e stamparlo
StampaVettoreOrdinato(vet);


//metodi
void StampaVettore(int[] v)
{
    for(int i = 0; i < v.Length; i++)
    {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine("\n");
}

void StampaVettoreOrdinato(int[] v)
{
    //ordino il vettore con il metodo del bubble sort
    for (int i = 0; i < v.Length - 1; i++)
        for (int j = 0; j < v.Length - i - 1; j++)
            if (v[j] > v[j + 1])
            {
                var temp = v[j];
                v[j] = v[j + 1];
                v[j + 1] = temp;
            }

    //stampo il vettore ordinato
    StampaVettore(v);
}