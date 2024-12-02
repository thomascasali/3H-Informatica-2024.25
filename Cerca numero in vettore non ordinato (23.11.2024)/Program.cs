/*
Istanzia un vettore da 1000 numeri interi e riempilo con numeri casuali da 1 a 1000
Chiedere quindi all'utente l'inserimento di un numero N compreso tra 1 e 1000 e
informare l'utente se il numero inserito è presente nel vettore e in quale posizione 
(nel caso in cui il numero sia presente più volte stamperà più volte la posizione del
numero, ad esempio, "TROVATO NELLA POSIZIONE 2")
 */

var vettore = new int[1000]; //vettore di interi
int n; //numero inserito dall'utente
var rnd = new Random(); //variabile per estrazione casuale

//riempimento del vettore
for(int i = 0; i < 1000; i++)
{
    vettore[i] = rnd.Next(1, 1001);
    //Console.Write(vettore[i] + " ");
}

do
{
    Console.WriteLine("Inserisci un numero compreso tra 1 e 1000");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1 || n > 1000) Console.WriteLine("Il numero inserito non è nell'intervallo richiesto");
} while (n < 1 || n > 1000);

for (int i = 0; i < 1000; i++)
{
    if (vettore[i] == n) Console.WriteLine("Il numero ricercato è presente alla posizione " + i);
}






