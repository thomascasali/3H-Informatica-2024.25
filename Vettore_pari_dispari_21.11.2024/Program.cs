var vettore = new int[100]; //istanzio un vettore di interi
int n; //contiene il numero di numeri da estrarre
var rnd = new Random(); //istanzio l'oggetto rnd che permetterà l'estrazione casuale di un numero
int contaPari = 0, sommaPari = 0, contaDispari = 0, sommaDispari = 0; //dichiaro e inizializzo le variabili per somma e conteggio
double mediaPari, mediaDispari; //dichiaro le variabili per contenere la media
string txtPari = ""; //variabile stringa per stampa testo concatenato dei numeri pari
string txtDispari = ""; //variabile stringa per stampa testo concatenato numeri dispari

do
{
    Console.WriteLine("Inserisci un numero da 10 a 100");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 10 || n > 100) Console.WriteLine("Il numero inserito non è corretto");
} while (n < 10 || n > 100);

Console.WriteLine("");
Console.WriteLine("Il vettore estratto è");
for (int i = 0; i < n; i++)
{
    vettore[i] = rnd.Next(1, 100); //estratto un numero casuale da 1 a 99
    Console.Write(vettore[i] + ", ");
}
Console.WriteLine("");
Console.WriteLine("");

for (int i=0; i<n; i++)
{
    if (vettore[i]%2==0)
    {
        contaPari = contaPari + 1; //incremento il conteggio dei numeri pari
        sommaPari = sommaPari + vettore[i]; //aumento la somma dei numeri pari
        txtPari = txtPari + Convert.ToString(vettore[i]) + ", "; //costruisco la stringa per la stampa dei numeri pari
    }
    else
    {
        contaDispari = contaDispari + 1; //incremento il conteggio dei numeri Dispari
        sommaDispari = sommaDispari + vettore[i]; //aumento la somma dei numeri Dispari
        txtDispari = txtDispari + Convert.ToString(vettore[i]) + ", "; //costruisco la stringa per la stampa dei numeri dispari
    }
}

Console.WriteLine("I numeri pari sono: " + txtPari);
Console.WriteLine("La somma dei numeri pari è " + sommaPari);
Console.WriteLine("La quantità di numeri pari è " + contaPari);
mediaPari = (double)sommaPari / contaPari;
Console.WriteLine("La media dei numeri pari è " + mediaPari);

Console.WriteLine();

Console.WriteLine("I numeri Dispari sono: " + txtDispari);
Console.WriteLine("La somma dei numeri Dispari è " + sommaDispari);
Console.WriteLine("La quantità di numeri Dispari è " + contaDispari);
mediaDispari = (double)sommaDispari / contaDispari;
Console.WriteLine("La media dei numeri Dispari è " + mediaDispari);


